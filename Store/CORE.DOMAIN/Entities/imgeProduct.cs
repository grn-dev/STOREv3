using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.DOMAIN.Entities
{
    public class imgeProduct
    {

        public int imgeProductID { get; set; }
        public string image { get; set; }
        public Product Product { get; set; }

    }
}
