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
        public DbSet<ImageProduct> imgeProducts { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<LogMaster> logMasters { get; set; }
        public DbSet<LogDetails> logDetails { get; set; }
        //public DbSet<GetProductByTag> GetProductByTags { get; set; }
        //public DbSet<productSingleImageCore> productSingleImageCores { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInfoConfiguration());
            base.OnModelCreating(modelBuilder);


        //    modelBuilder.Entity<productSingleImageCore>()
        //.HasNoKey();
            //modelBuilder.Entity<Product>()
            //            .HasOne<ImageProduct>(e => e.)
            //            .WithMany(e => e.)
            //            .HasForeignKey(e => e.AId)
            //            .OnDelete(DeleteBehavior.Cascade); // <= This entity has cascading behaviour on deletion




            //    modelBuilder.Entity<Product>()
            //.HasMany(c => c.imageProducts)
            //.WithOne(e => e.Product)
            //.IsRequired();


            //    modelBuilder.Entity<ImageProduct>()
            //    .HasOne(e => e.Product)
            //    .WithMany(c => c.imageProducts);


            ///از پایین باید شروع کنیم

            //modelBuilder.Entity<ImageProduct>()
            //           .HasOne(e => e.product)
            //           .WithMany(e => e.imageProducts)
            //           .HasForeignKey(e => e.productID)
            //           .OnDelete(DeleteBehavior.Restrict); // <=



            modelBuilder.Entity<ProductInfo>()
       .HasOne(c => c.product)
       .WithMany(e => e.ProductInfos).OnDelete(DeleteBehavior.Cascade);


        }

    }
}
