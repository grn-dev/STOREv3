using Core.Domian;
using Infrastructures.Dal.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Dal
{
    public class ContextMed : DbContext
    {
        /*protected override void OnConfiguring(DbContext_OptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PHONEBOOK;Integrated Security=True;");

            base.OnConfiguring(optionsBuilder);
        }*/

         
        public ContextMed(DbContextOptions<ContextMed> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
