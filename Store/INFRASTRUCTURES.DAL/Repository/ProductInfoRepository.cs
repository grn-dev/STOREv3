using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRASTRUCTURES.DAL.Repository
{
    public class ProductInfoRepository : BaseRepository<ProductInfo>, IAsyncProductInfo
    {
        private readonly ContextMed ctx;
        public ProductInfoRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public bool CheckExistAsync(int ProductID, string keyname, string Value)
        {
            return ctx.ProductInfo.Any(c => c.productID == ProductID && c.Value == Value && c.key == keyname);
        }

        public async Task<ICollection<string>> GetMoreInfoAsync(int ProductID, string keyname)
        {
            return await ctx.ProductInfo.
                Where(c => c.key == keyname && c.product.ProductID == ProductID).
                Select(c => c.Value).
                ToListAsync();
        }
    }
}
