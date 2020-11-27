using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Models
{
    public class productMultiImage
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

    }
}
