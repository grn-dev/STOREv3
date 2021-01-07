using Core.Contract;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using EndPoint.UI.panelAdmin.Models.Account;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using INFRASTRUCTURES.DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EndPoint.UI.panelAdmin
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
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;

            //}); 


            services.AddMemoryCache();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();

            services.AddDbContext<ContextMed>(options => options.UseSqlServer
            (Configuration.GetConnectionString("storeDb")));
            
            services.AddScoped<IAsyncPruductRepo, ProductRepository>();
            services.AddScoped<IAsyncCategoriRepo, CategoriRepo>();
            services.AddScoped<IAsyncImageValue, IImageValueRepository>();
            services.AddScoped<IAsyncProductInfo, ProductInfoRepository>();


            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("storeUserDb")));

            //services.Add<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<AppIdentityDbContext>();

              


            services.AddIdentity<Appuser, IdentityRole>(c =>
            {

                c.Password.RequireDigit = false;
                c.Password.RequiredLength = 5;
                c.Password.RequireNonAlphanumeric = false;
                c.Password.RequireUppercase = false;
                c.Password.RequireLowercase = false;


            }).AddEntityFrameworkStores<AppIdentityDbContext>()
            .AddDefaultTokenProviders();

            //services.AddRazorPages();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseCookieAuthenticati
            app.UseSession();

             
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
                    //pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
