using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRASTRUCTURES.DAL.Repository
{
    public class imgeProductRepository: BaseRepository<imgeProduct>, IimgeProduct
    {
        private readonly ContextMed ctx;
        public imgeProductRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public List<imgeProduct> AddList(List<imgeProduct> entity)
        {
            ctx.Set<imgeProduct>().AddRangeAsync(entity);
            ctx.SaveChanges();
            return entity;
        }
    }
}
