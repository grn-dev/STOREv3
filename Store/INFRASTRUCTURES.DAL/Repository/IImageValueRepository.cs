using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRASTRUCTURES.DAL.Repository
{
    public class IImageValueRepository: BaseRepository<ImageProduct>, IAsyncImageValue
    {
        private readonly ContextMed ctx;
        public IImageValueRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

         
    }
}
