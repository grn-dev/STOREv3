using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using Microsoft.EntityFrameworkCore;
using INFRASTRUCTURES.DAL.ResultStoredProcedure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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


//var query =
//                     (from INFO in ctx.ProductInfo

//                      join PRJ in ctx.Products on INFO.productID equals PRJ.ProductID
//                      //GroupBy(x => new { x.bn.DEUF, x.bn.DESUPERINTENDENCIAREGIONAL, x.cr.SITUACAODIVIDA })

//                      where INFO.key == "TAG"
//                      && INFO.Value == ProductName
//                      && string.IsNullOrWhiteSpace(ProductName) || INFO.Value.Contains(ProductName)
//                      group PRJ by new { PRJ } into PR

//                      select new Product()
//                      {

//                      }
//                      ).
//                      Skip(pageSize * (pageNumber - 1)).
//                      Take(pageSize).ToList();



////ContextMed ctx;
//public static class Helper
//{
//    public static List<T> RawSqlQuery<T>(string query, Func<DbDataReader, T> map)
//    {
//        using (var context = new ContextMed())
//        {
//            using (var command = context.Database.GetDbConnection().CreateCommand())
//            {
//                command.CommandText = query;
//                command.CommandType = CommandType.Text;

//                context.Database.OpenConnection();

//                using (var result = command.ExecuteReader())
//                {
//                    var entities = new List<T>();

//                    while (result.Read())
//                    {
//                        entities.Add(map(result));
//                    }

//                    return entities;
//                }
//            }
//        }
//    }
//}



 