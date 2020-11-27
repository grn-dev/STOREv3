using Core.Contract;
using Core.Domian;

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
//using System.Data.Common.;//.Core.Objects;

namespace Infrastructures.Dal.Repository
{
    public class ProductRepository : BaseRepository<Product>, IPruductRepo
    {
        private readonly ContextMed ctx;
        public ProductRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public List<Product> GetProducts(int pageSize = 4, int pageNumber = 1, string category = null)
        {
            return ctx.Products.
                Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).
                Include(c => c.Category).
                Skip(pageSize * (pageNumber - 1)).
                Take(pageSize).ToList();

        }
        public int TotalCount(string category = null)//page/4 ,categori
        {
            return ctx.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).Count();
        }


        public List<Product> searchByname(string name)
        {
            return ctx.Products.Where(c => c.Name.Contains(name)).ToList();
        }

        public int TotalCountSearch(string name)
        {
            return ctx.Products.Where(c => string.IsNullOrWhiteSpace(name) || c.Name.Contains(name)).Count();
        }

        public List<Product> GetProductsSearch(int pageSize = 4, int pageNumber = 1, string name = null)
        {
            return ctx.Products.
                Where(c => string.IsNullOrWhiteSpace(name) || c.Name.Contains(name)).
                Include(c => c.Category).
                Skip(pageSize * (pageNumber - 1)).
                Take(pageSize).ToList();
        }

        public List<Product> GetReletionPruduct(Product prc)
        {
            //return ctx.Products.ToList();
            //return ctx.Products.Where(c=> c.CategoryId == prc.ProductID).ToList();
            return ctx.Products.Take(6).ToList();
        }

        public List<Product> GetProductByGategoriMainPage(string categoriName)
        {


            var query = ctx.Products.Where(c => c.Category.CategoryName == categoriName).Take(6).ToList();

            //var query2 = ctx.Products.SingleOrDefault(c => c.Category.CategoryName == categoriName);

            //var sql = ((System.Data.Objects.ObjectQuery)query).ToTraceString();

            //string sql = ((System.Data.Objects
            //    .ObjectQuery)query).ToTraceString();
            //ctx.SaveChangesAsync().Wait();
            //using (ctx)
            //{
            //    ctx.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //    // query the database using EF here.
            //}


            //var sql = query.ToString();

            return query;





        }

        public List<Product> imgeForsingle()
        {
            return ctx.Products.Include(c => c.Images).Take(3).ToList();
        }

        //public int TotalCount(string category)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
