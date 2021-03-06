﻿using Core.Domian;
using EndPoints.WebUI.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Models.Product
{
    public class ProductsListViewModel
    {
        public List<productSingleImage> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string Current { get; set; }
        public string fromContoller { get; set; }
        public List<Category> CategoryChild { get; set; }

    }
}
