using Core.Domian;
using EndPoints.WebUI.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoints.WebUI.Models.Search
{
    public class SeachViewModel
    {
        public List<Product> Products { get; set; }
        public SearchPagingInfo PagingInfo { get; set; }
    }
}
