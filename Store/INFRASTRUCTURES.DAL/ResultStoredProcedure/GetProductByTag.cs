using System;
using System.Collections.Generic;
using System.Text;

namespace INFRASTRUCTURES.DAL.ResultStoredProcedure
{
    public class GetProductByTag01
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string mainImages { get; set; }
        public int CategoryId { get; set; }
     
    }
}
