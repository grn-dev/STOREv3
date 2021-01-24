using Core.Domian;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructures.Dal.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(c => c.Name).IsUnique();
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(500);
            
            
            
//            builder.Property(c => c.ProductInfos).

           



        }
    }
}
