using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using Infrastructures.Dal;
using Infrastructures.Dal.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFRASTRUCTURES.DAL.Repository
{
    public class LogMasterRepository : BaseRepository<LogMaster>, ILogMaster
    {
        private readonly ContextMed ctx;
        public LogMasterRepository(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public IEnumerable<LogMaster> GetLogMasters()
        {
            var LogMasterResult = ctx.logDetails.GroupBy(x => x.productID).Select(y => new LogMaster
            {
                productID =y.Key ,
                CountVisit = y.Count()
            }).ToList();
             
            return LogMasterResult;
             
        }

        public void insertBulk(List<LogMaster> logMasters)
        {
            ctx.logMasters.AddRange(logMasters);
            ctx.SaveChanges();
        }

        public override IEnumerable<LogMaster> GetAll( )
        {
            var rew2 = ctx.logMasters.Include(c => c.product)
                .OrderByDescending(x => x.CountVisit)
                .Select(x => new LogMaster()
                {

                    product = new Product()
                    {
                        Name = x.product.Name
                    }, 
                    CountVisit=x.CountVisit,
                    productID=x.productID,
                    LogMasterID=x.LogMasterID
                    
                })
                .Take(50)
                .ToList();

            return rew2;
        }
    }
}
