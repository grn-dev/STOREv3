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
    public class LogDetailsRepositoty : BaseRepository<LogDetails>, ILogDetails
    {
        private readonly ContextMed ctx;
        public LogDetailsRepositoty(ContextMed dbContext_) : base(dbContext_)
        {
            ctx = dbContext_;
        }

        public void DeleteAll()
        {
            var res=ctx.Database.ExecuteSqlRaw("TRUNCATE TABLE [LogDetails]"); 
             
        }

        public override IEnumerable<LogDetails> GetAll()
        {

            //SQL PROFILER
            //var rew = ctx.logDetails.Include(x => x.product).ToList();
            var rew2 = ctx.logDetails.Include(c => c.product)
                .OrderByDescending(x => x.VisitTime)
                .Select(x => new LogDetails()
                { 

                    product = new Product()
                    {
                        Name = x.product.Name
                    },
                    VisitTime= x.VisitTime,
                    IP=x.IP
                })
                .Take(50)
                .ToList(); 

            return rew2;
        }

    }
}
