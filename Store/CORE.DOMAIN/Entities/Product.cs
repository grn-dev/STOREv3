using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domian
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ImageValue> Images { get; set; }
        public string mainImages { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool isShow { get; set; }
        public int count { get; set; }

        public List<ProductInfo> ProductInfos { get; set; }

        //Dictionary<string, string> keyValues = new Dictionary<string, string>();


        //public bool IsShow { get; set; }
        //public int Count { get; set; }
        //public string MoreDescription { get; set; }
    }

    public class productSingleImageCore
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string mainImages { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Place { get; set; }
    }

}
