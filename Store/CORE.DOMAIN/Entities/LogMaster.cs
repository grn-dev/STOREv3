using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.DOMAIN.Entities
{
    public class LogMaster
    {
        public int LogMasterID { get; set; }
        public Product product { get; set; }
        public int productID { get; set; }
        public int CountVisit { get; set; }

    }
}
