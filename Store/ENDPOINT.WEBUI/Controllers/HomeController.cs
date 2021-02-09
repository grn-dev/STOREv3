using AutoMapper;
using Core.Contract;
using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;
using ENDPOINT.WEBUI.Pattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace ENDPOINT.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsyncPruductRepo RepoPrc;
        private readonly IMapper _mapper;
        private readonly IAsyncProductInfo ProductInfoREPO;
        private readonly ILogger _logger;

        public HomeController(IAsyncProductInfo ProductInfoREPO_,
            IAsyncPruductRepo pruduct, IMapper _mapper1, ILogger<HomeController> logger)
        {
            RepoPrc = pruduct;
            _mapper = _mapper1;
            ProductInfoREPO = ProductInfoREPO_;
            //ProductInfoREPO.GetProductByTag(1, 1, "");
            _logger = logger;

        }




        public IActionResult Index()
        {  
            var mainPageobj = MainPageSingleton.GetInstance(RepoPrc, _mapper);

             
            return View(mainPageobj);


        }
        //public void Base64ToImage(string source)
        //{
        //    string base64 = source.Substring(source.IndexOf(',') + 1);
        //    base64 = base64.Trim('\0');
        //    byte[] chartData = Convert.FromBase64String(base64);
        //} 
        public string Getimage(int ProuductID)
        {
            string base61ex = "sabzali";
            var jsonR = Newtonsoft.Json.JsonConvert.SerializeObject(base61ex);
            return jsonR;
        }

        public IActionResult Partial1()
        {
            var _Partial1 = _mapper.Map<List<Product>, List<productSingleImage>>
                ((RepoPrc.GetProductmainPagev2("_Partial1")).ToList());//new List<productSingleImage>(),
            return PartialView("~/_Partial1", _Partial1);
        }
        public void ResetMain()
        {
            MainPageSingleton.DoItNull();
        }
        public IActionResult Partial2()
        {
            var _Partial1 = _mapper.Map<List<Product>, List<productSingleImage>>
                ((RepoPrc.GetProductmainPagev2("_Partial2")).ToList());//new List<productSingleImage>(),
            return PartialView("~/_Partial2", _Partial1);
        }
        public IActionResult Partial3()
        {
            var _Partial1 = _mapper.Map<List<Product>, List<productSingleImage>>
                ((RepoPrc.GetProductmainPagev2("_Partial3")).ToList());//new List<productSingleImage>(),
            return PartialView("~/_Partial3", _Partial1);
        }
    }
}

