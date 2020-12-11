using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.DOMAIN.Entities
{
    public class ProductInfo
    {
        public int ProductInfoID { get; set; }
        public string key { get; set; }
        public string Value { get; set; }
        //public string ValueInt { get; set; }

        public int productID { get; set; }
        public Product product { get; set; }
        


    }
}
