using Core.Domian;
using CORE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructures.Dal.Config
{
    public class ProductInfoConfiguration : IEntityTypeConfiguration<ProductInfo>
    {
        public void Configure(EntityTypeBuilder<ProductInfo> builder)
        {


            builder.Property(c => c.Value).HasMaxLength(150);
            builder.Property(c => c.key).HasMaxLength(70).IsRequired();
            
              
        }
    }
}
