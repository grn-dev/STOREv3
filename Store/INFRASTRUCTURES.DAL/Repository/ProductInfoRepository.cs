using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFRASTRUCTURES.DAL.Repository
{
    public class ProductInfoRepository : BaseRepository<ProductInfo>, IProductInfo
    {
        private readonly ContextMed ctx;
        public ProductInfoRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public List<string> GetMoreInfo(int ProductID, string keyname)
        {

            return ctx.ProductInfo.
                Where(c => c.key == keyname && c.product.ProductID == ProductID).
                Select(c=> c.Value).
                ToList();


        }
    }
}
