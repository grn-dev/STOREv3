﻿using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using INFRASTRUCTURES.DAL.ResultStoredProcedure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;


namespace INFRASTRUCTURES.DAL.Repository
{
    public class ProductInfoRepository : BaseRepository<ProductInfo>, IProductInfo
    {
        private readonly ContextMed ctx;
        public ProductInfoRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public bool CheckExist(int ProductID, string keyname, string Value)
        {
            return ctx.ProductInfo.Any(c => c.productID == ProductID && c.Value == Value && c.key == keyname);
        }

        public List<string> GetMoreInfo(int ProductID, string keyname)
        {

            return ctx.ProductInfo.
                Where(c => c.key == keyname && c.product.ProductID == ProductID).
                Select(c => c.Value).
                ToList();


        }


        public List<GetProductByTag> GetProductByTag(int pageSize = 4, int pageNumber = 1, string ProductName = null)
        {

            var results = ctx.Set<GetProductByTag>().FromSqlRaw("exec SP_GetProductByTag '',1,1").ToList();
            return results;
             
            //var userType = ctx.Set().FromSql("dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada");
            //ctx.Database.ExecuteSqlCommand()
            //ctx.Products.FromSql("GetStudents 'Bill'").ToList();
            //IList<TEntity> ts = new List<GetProductByTag>();
            //IList<TEntity> ts = new List<TEntity>();
            //var user = new SqlParameter("user", "johndoe");

            // var userTypeProductsoaramslissdst = ctx.Set<GetProductByTag>().FromSqlRaw("exec SP_testCategories").ToList();


            //var userTypeProductsoaramslisttestresult = ctx.testresult.FromSqlRaw("exec SP_testCategories").ToList();
            //var userTypeProductsoaramslist = ctx.Products.FromSqlRaw("exec SP_testCategories").ToList();

            //var userTypeProductsoaramslissdstsds = ctx.Set<testresult>().FromSqlRaw("exec SP_testCategories")
            //    .Select(e => (object)e)
            //    .ToList();
            //var userTypeProductsoarams = ctx.Products.FromSqlRaw("exec SP_testCategories");
            //var u85 = ctx.Products.FromSqlRaw("select 85 where 1=1").ToList();
            //var sdfsd = ctx.Database.ExecuteSqlRaw("exec SP_testCategories");
            //var sdfssdd = ctx.Database.ExecuteSqlRaw(@"select 85 where 1=1");
            //var userType = ctx.Set().FromSql("dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada");
            //var userTypeProducts = ctx.Products.FromSqlRaw("exec SP_GetProductByTag '',1,1");
            //var userTypeProductsoarams2 = ctx.Products.FromSqlRaw("exec SP_GetProductByTag", "", 1, 1);
            //ctx.Products.FromSqlRaw("GetStudents 'Bill'").ToList();
            //ctx.Database.FromSqlRaw("GetStudents 'Bill'").ToList();
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



 