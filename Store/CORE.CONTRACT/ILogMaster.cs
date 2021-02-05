using Core.Contract;
using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.CONTRACT
{
    public interface ILogMaster : IAsyncRepository<LogMaster>
    {
        IEnumerable<LogMaster> GetLogMasters();
        void insertBulk(List<LogMaster> logMasters);
    }
}
