using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.DOMAIN.Entities
{
    public class ImageProduct
    {

        public int ID { get; set; }
        public string image { get; set; }
         
        public int productID { get; set; }
        public Product product { get; set; }

    } 
}
