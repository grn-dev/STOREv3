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
        public List<string> Images { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //public bool IsShow { get; set; }
        //public int Count { get; set; }
        //public string MoreDescription { get; set; }
    }
}
