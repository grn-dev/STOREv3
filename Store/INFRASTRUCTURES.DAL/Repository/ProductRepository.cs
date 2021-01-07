using Core.Contract;
using Core.Domian;

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

//using System.Data.Common.;//.Core.Objects;

namespace Infrastructures.Dal.Repository
{
    public class ProductRepository : BaseRepository<Product>, IAsyncPruductRepo
    {
        private readonly ContextMed ctx;

        public ProductRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        //public Task<IEnumerable<Product>> GetProductByGategoriMainPageAsync(string categoriName)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<Product>> GetProductmainPageAsync(string place)
        {
            var query =
             (from INFO in ctx.ProductInfo
              join PR in ctx.Products on INFO.productID equals PR.ProductID
              where INFO.key == "placeProduct" && INFO.Value == place.Trim()

              select (PR)).ToListAsync();

            //var dfd = _mapper.Map<List<Product>>(query);
            //List<string> relerted = ProductInfoREPO.GetMoreInfo(ProductID, "RelatedProduct");
            //return ctx.Products.Where(c=> c.CategoryId == prc.ProductID).ToList();
            return await query;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(int pageSize = 4, int pageNumber = 1, string category = null)
        {
            return await ctx.Products.
                    Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).
                    Include(c => c.Category).
                    Include(c => c.Images).
                    Skip(pageSize * (pageNumber - 1)).
                    Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsbyParentcategoriAsync(int pageSize = 4, int pageNumber = 1, string category = null)
        {
            var dfdfdf = ctx.Categories.Where(x => x.CategoryName == category).Include(x => x.Childeren).ToList().Select(c => c.CategoryName);

            return await ctx.Products.
                Where(c => string.IsNullOrWhiteSpace(category) || dfdfdf.Contains(c.Category.CategoryName)).
                Include(c => c.Category).
                Include(c => c.Images).
                Skip(pageSize * (pageNumber - 1)).
                Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsSearchAsync(int pageSize = 4, int pageNumber = 1, string name = null)
        {
            return await ctx.Products.
                    Where(c => string.IsNullOrWhiteSpace(name) || c.Name.Contains(name)).
                    Include(c => c.Category).
                    Include(c => c.Images).
                    Skip(pageSize * (pageNumber - 1)).
                    Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetReletionPruductAsync(int prcID)
        {
            var query =
             (from INFO in ctx.ProductInfo
              join PR in ctx.Products on INFO.productID equals PR.ProductID
              where INFO.key == "RelatedProduct" && INFO.productID == prcID

              select (PR)).ToListAsync();
             
            return await query;
        }

        public async Task<Product> GetSingleProductAsync(int ProductID)
        {
            return await ctx.Products.Where(c => c.ProductID == ProductID).Include(c => c.Images).FirstOrDefaultAsync();
        }

        public async  Task<IEnumerable<Product>> imgeForsingleAsync()
        {
            return await ctx.Products.Include(c => c.Images).Take(3).OrderByDescending(c => c.ProductID).ToListAsync();
        }

        public async Task<IEnumerable<Product>> searchBynameAsync(string name)
        {
            return await ctx.Products.Where(c => c.Name.Contains(name)).ToListAsync();
        }

        public async Task<int> TotalCountAsyn(string category = null)
        {
            return await ctx.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).CountAsync();
        }

        public async Task<int> TotalCountSearchAsync(string name)
        {
            return await ctx.Products.Where(c => string.IsNullOrWhiteSpace(name) || c.Name.Contains(name)).CountAsync();
        }
    }

}
