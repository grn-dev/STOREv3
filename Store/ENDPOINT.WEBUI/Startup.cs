
using Core.Contract;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using INFRASTRUCTURES.DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ENDPOINT.WEBUI.Models;
using Core.Domian;

namespace ENDPOINT.WEBUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSession();
            services.AddMemoryCache();

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, productSingleImage>();
                cfg.CreateMap<productSingleImageCore, productSingleImage>();
                cfg.CreateMap<Product, GetProductByTag>();
                cfg.CreateMap<GetProductByTag, Product>();
                //cfg.CreateMap<productSingleImage, productSingleImageCore>();
                //cfg.CreateMap<Bar, BarDto>();
            });

            IMapper mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);


            //configuration.AssertConfigurationIsValid();
            //// use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            //var mapper1 = configuration.CreateMapper();


            services.AddControllersWithViews();
            services.AddDbContext<ContextMed>(options => options.UseSqlServer
            (Configuration.GetConnectionString("storeDb")));
            services.AddScoped<IAsyncPruductRepo, ProductRepository>();
            services.AddScoped<IAsyncImageValue, IImageValueRepository>();
            services.AddScoped<IAsyncProductInfo, ProductInfoRepository>();

            services.AddScoped<IAsyncCategoriRepo, CategoriRepo>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
