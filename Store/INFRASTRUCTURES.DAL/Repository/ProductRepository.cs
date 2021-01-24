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
        public override IEnumerable<Product> GetAll()
        {
            //x.Description, x.Name, x.ProductID
            return ctx.Products.Select(x => new Product
            {
                ProductID = x.ProductID,
                Name = x.Name,
                //Description = x.Description.Substring(0, 15),
                Description = (x.Description.Length > 15) ? x.Description.Substring(0, 15) : x.Description,
            }).OrderByDescending(x => x.ProductID).ToList();
        }
        //public Task<IEnumerable<Product>> GetProductByGategoriMainPageAsync(string categoriName)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<productSingleImageCore>> GetProductmainPageAsync()
        //{ 
        //    var results = ctx.Set<productSingleImageCore>().FromSqlRaw("exec SP_GetMainPage").ToListAsync();
        //    return await results;

        //}

        public async Task<IEnumerable<Product>> GetProductsAsync(int pageSize = 4, int pageNumber = 1, string category = null)
        {
            return await ctx.Products.
                    Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).
                    Include(c => c.Category).
                    Include(c => c.imageProducts).
                    Skip(pageSize * (pageNumber - 1)).
                    Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsbyParentcategoriAsync(int pageSize = 4, int pageNumber = 1, string category = null)
        {

            int CAtegoriID = ctx.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryId;
            var results = ctx.Set<Product>().FromSqlRaw("exec SP_GetProductsbyParentcategori {0}, {1},{2}", pageSize, pageNumber, CAtegoriID).ToListAsync();
            return await results;
        }

        public async Task<IEnumerable<Product>> GetProductsSearchAsync(int pageSize = 4, int pageNumber = 1, string name = null)
        {
            return await ctx.Products.
                    Where(c => string.IsNullOrWhiteSpace(name) || c.Name.Contains(name)).
                    Include(c => c.Category).
                    Include(c => c.imageProducts).
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
            return await ctx.Products.Where(c => c.ProductID == ProductID).Include(c => c.imageProducts).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> imgeForsingleAsync()
        {
            return await ctx.Products.Include(c => c.imageProducts).Take(3).OrderByDescending(c => c.ProductID).ToListAsync();
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

        public async Task<int> TotalCountAsyn(string category = null)
        {
            return await ctx.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).CountAsync();
        }

        public async Task<IEnumerable<Product>> searchBynameAsync(string name)
        {
            return await ctx.Products.Where(c => c.Name.Contains(name)).ToListAsync();
        }

        public int TotalCountSearch(string name)
        {
            return ctx.Products.Where(c => string.IsNullOrWhiteSpace(name) || c.Name.Contains(name)).Count();
        }

        public Product GetSingleProduct(int ProductID)
        {
            return ctx.Products.Where(c => c.ProductID == ProductID).Include(c => c.imageProducts).FirstOrDefault();
        }

        public IEnumerable<Product> GetReletionPruduct(int prcID)
        {
            var results = ctx.Set<Product>().FromSqlRaw("exec SP_GetReletedPruduct {0}", prcID).ToList();
            return results;

        }

        public async Task<IEnumerable<Product>> GetProductmainPageAsync(string place)
        {
            var results = ctx.Set<Product>().FromSqlRaw("exec SP_GetMainPage {0}", place).ToListAsync();
            return await results;
        }

        public IEnumerable<Product> GetProductmainPagev2(string place)
        {
            var results = ctx.Set<Product>().FromSqlRaw("exec SP_GetMainPage {0}", place).ToList();
            return results;
        }



        //public IEnumerable<Product> GetProductmainPage(string place)
        //{
        //    var results = ctx.Set<Product>().FromSqlRaw("exec SP_GetMainPage {0}", place).ToList();
        //    return results;
        //}
    } 

}
