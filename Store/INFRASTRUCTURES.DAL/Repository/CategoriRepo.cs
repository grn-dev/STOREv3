using Core.Contract;
using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class CategoriRepo : BaseRepository<Category>, ICategoriRepo
    {
        private readonly ContextMed ctx;
        public CategoriRepo(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public Category GetByName(string catname)
        {
            return ctx.Categories.FirstOrDefault(c => c.CategoryName == catname);

        }

        public List<Category> GetCategorylevel1()
        {
            return ctx.Categories.Where(x => x.parentId == null).ToList();
        }

        public List<Category> GetCategorylevel2()
        {
            //return ctx.Categories.Where(x => x.parentId == null).ToList().Select(x => x.Childeren);


            var query =
                     (from lvl1 in ctx.Categories
                      join lvl2 in ctx.Categories on lvl1.CategoryId equals lvl2.parentId

                      select new Category { 
                      CategoryId=lvl2.CategoryId,
                      CategoryName=lvl2.CategoryName,
                      parentId=lvl2.parentId,
                      
                      }).ToList();


            return query;
        }
        public List<Category> GetCategoryByparent(int ParentID)
        {
            return ctx.Categories.Where(x => x.parentId == ParentID).ToList();
        }

        public List<Category> GetCategorylevel2(string parentName)
        {
            var sdsd = ctx.Categories.FirstOrDefault(c => c.CategoryName == parentName);
            return ctx.Categories.Where(x => x.parentId == sdsd.CategoryId).ToList();
        }
    }
}
