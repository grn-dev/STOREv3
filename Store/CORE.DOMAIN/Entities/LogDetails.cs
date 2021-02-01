using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.DOMAIN.Entities
{
    public class LogDetails
    {
        public int LogDetailsID { get; set; }
        public Product product { get; set; }
        public int productID { get; set; }
        public DateTime VisitTime { get; set; }
    }
}
