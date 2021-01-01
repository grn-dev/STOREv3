using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal.Config;
using INFRASTRUCTURES.DAL.ResultStoredProcedure;
using Microsoft.EntityFrameworkCore; 
namespace Infrastructures.Dal
{
    public class ContextMed : DbContext
    {


        public ContextMed(DbContextOptions<ContextMed> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImageValue> imgeProducts { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<GetProductByTag> GetProductByTags { get; set; }

 
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInfoConfiguration());
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<GetProductByTag>().HasNoKey();

            //modelBuilder.GetType().(t => t.MapToStoredProcedures());

            //modelBuilder.Entity<Product>()
            //       .ma

            //    modelBuilder.Entity<Product>()
            //.HasMany(c => c.Images)
            //.WithOne(e => e.Product)
            //.IsRequired();


            //    modelBuilder.Entity<ImageValue>()
            //    .HasOne(e => e.Product)
            //    .WithMany(c => c.Images);




            modelBuilder.Entity<ProductInfo>()
       .HasOne(c => c.product)
       .WithMany(e => e.ProductInfos).OnDelete(DeleteBehavior.Cascade);


        }

    }
}
