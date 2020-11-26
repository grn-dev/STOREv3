using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Dal
{
    public class ContextMed : DbContext
    {


        public ContextMed(DbContextOptions<ContextMed> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<imgeProduct> imgeProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>()
        .HasMany(c => c.Images)
        .WithOne(e => e.Product)
        .IsRequired();


            modelBuilder.Entity<imgeProduct>()
            .HasOne(e => e.Product)
            .WithMany(c => c.Images);


        }
    }
}
