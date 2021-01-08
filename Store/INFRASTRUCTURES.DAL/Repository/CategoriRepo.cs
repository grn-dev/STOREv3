using Core.Contract;
using Core.Domian;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Dal.Repository
{
    public class CategoriRepo : BaseRepository<Category>, IAsyncCategoriRepo
    {
        private readonly ContextMed ctx;
        public CategoriRepo(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public async Task<Category> GetByNameAsync(string catname)
        {

            return await ctx.Categories.FirstOrDefaultAsync(c => c.CategoryName == catname);

        }

        public IEnumerable<Category> GetCategorylevel1()
        {
            return ctx.Categories.Where(x => x.parentId == null).ToList();
        }

        public IEnumerable<Category> GetCategorylevel2()
        {
            var query =
                     (from lvl1 in ctx.Categories
                      join lvl2 in ctx.Categories on lvl1.CategoryId equals lvl2.parentId

                      select new Category
                      {
                          CategoryId = lvl2.CategoryId,
                          CategoryName = lvl2.CategoryName,
                          parentId = lvl2.parentId,

                      }).ToList();


            return query;
        }
        public List<Category> GetCategoryByparent(int ParentID)
        {
            return ctx.Categories.Where(x => x.parentId == ParentID).ToList();
        }

        public IEnumerable<Category> GetCategorylevel2Async(string parentName)
        {
            var sdsd = ctx.Categories.FirstOrDefault(c => c.CategoryName == parentName);
            return ctx.Categories.Where(x => x.parentId == sdsd.CategoryId).ToList();
        }

        
    }
}
