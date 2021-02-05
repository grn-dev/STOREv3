using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal.Config;
using INFRASTRUCTURES.DAL.Config;
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
            modelBuilder.ApplyConfiguration(new LogDetailsConfiguration());
            base.OnModelCreating(modelBuilder);
             

            modelBuilder.Entity<ProductInfo>()
                    .HasOne(c => c.product)
                    .WithMany(e => e.ProductInfos).OnDelete(DeleteBehavior.Cascade);


        }

    }
}
