﻿using Core.Domian;
using CORE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Models
{
    public class productMultiImage
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<imgeProduct> AllImages { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

    }
}