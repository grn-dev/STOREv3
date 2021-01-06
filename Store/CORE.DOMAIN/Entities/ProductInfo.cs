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

    public class GetProductByTag
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string mainImages { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

    }
}
