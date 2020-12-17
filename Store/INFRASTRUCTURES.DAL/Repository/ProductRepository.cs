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

        public override IQueryable<Product> GetAll()
        {
            return ctx.Products.Where(c => c.isShow == true).AsQueryable();
        }
        public List<Product> GetProducts(int pageSize = 4, int pageNumber = 1, string category = null)
        {
            return ctx.Products.
                Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).
                Include(c => c.Category).
                Include(c => c.Images).
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
                Include(c => c.Images).
                Skip(pageSize * (pageNumber - 1)).
                Take(pageSize).ToList();
        }

        public List<Product> GetReletionPruduct(int prc)
        {
            //return ctx.Products.ToList();


            var query =
                     (from INFO in ctx.ProductInfo
                      join PR in ctx.Products on INFO.productID equals PR.ProductID
                      where INFO.key == "RelatedProduct" && INFO.productID == prc

                      select (PR)).ToList();

            //var dfd = _mapper.Map<List<Product>>(query);
            //List<string> relerted = ProductInfoREPO.GetMoreInfo(ProductID, "RelatedProduct");
            //return ctx.Products.Where(c=> c.CategoryId == prc.ProductID).ToList();
            return query;
        }

        public List<Product> GetProductByGategoriMainPage(string categoriName)
        {


            var query = ctx.Products.Where(c => c.Category.CategoryName == categoriName).Take(6).ToList();
             

            return query;





        }

        public List<Product> imgeForsingle()
        {
            return ctx.Products.Include(c => c.Images).Take(3).OrderByDescending(c => c.ProductID).ToList();
        }

        public Product GetSingleProduct(int ProductID)
        {
            return ctx.Products.Where(c => c.ProductID == ProductID).Include(c => c.Images).FirstOrDefault();
        }

        public List<Product> GetProductmainPage(string place)
        {
            var query =
                     (from INFO in ctx.ProductInfo
                      join PR in ctx.Products on INFO.productID equals PR.ProductID
                      where INFO.key == "placeProduct" && INFO.Value == place.Trim()

                      select (PR)).ToList();

            //var dfd = _mapper.Map<List<Product>>(query);
            //List<string> relerted = ProductInfoREPO.GetMoreInfo(ProductID, "RelatedProduct");
            //return ctx.Products.Where(c=> c.CategoryId == prc.ProductID).ToList();
            return query;
        }
         
    }

}
