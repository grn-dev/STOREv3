﻿using AutoMapper;
using Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Models.Product
{
    public class MainPage
    {
        //private  readonly IAsyncPruductRepo RepoPrc;
        //private  readonly IMapper _mapper;
        //public MainPage(IAsyncPruductRepo RepoPrc_, IMapper _mapper1)
        //{
        //    RepoPrc = RepoPrc_;
        //    _mapper = _mapper1;
        //}
        public List<productSingleImage> _PartialCard2 { get; set; }
        public List<productSingleImage> _Partial1 { get; set; }
        public List<productSingleImage> _Partial2 { get; set; }
        public List<productSingleImage> _Partial3 { get; set; }
    }
}
