using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace INFRASTRUCTURES.DAL.Repository
{
    public class LogMasterRepository: BaseRepository<LogMaster>, ILogMaster
    {
        private readonly ContextMed ctx;
        public LogMasterRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }
    }
}
