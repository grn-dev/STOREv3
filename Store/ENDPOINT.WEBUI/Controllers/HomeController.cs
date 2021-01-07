using AutoMapper;
using Core.Contract;
using Core.Domian;
using CORE.CONTRACT;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsyncPruductRepo RepoPrc;
        private readonly IMapper _mapper;
        private readonly IAsyncProductInfo ProductInfoREPO;
        public HomeController(IAsyncProductInfo ProductInfoREPO_, IAsyncPruductRepo pruduct, IMapper _mapper1)
        {
            RepoPrc = pruduct;
            _mapper = _mapper1;
            ProductInfoREPO = ProductInfoREPO_;
            //ProductInfoREPO.GetProductByTag(1, 1, "");
        }

        public IActionResult Index()
        {
            //var _PartialCard23 = RepoPrc.GetProductmainPage("_PartialCard2");
            //var _Partial13 = RepoPrc.GetProductmainPage("_Partial1");
            //var _Partial23 = RepoPrc.GetProductmainPage("_Partial2");
            //var _Partial33 = RepoPrc.GetProductmainPage("_Partial3");

            var AllmainPage = RepoPrc.GetProductmainPageAsync().Result.ToList();

            ////var _PartialCard2 = _mapper.Map<List<Product>, List<productSingleImage>>(RepoPrc.GetProductmainPage("_PartialCard2"));
            var _Partial1 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(AllmainPage.Where(x => x.Place == "_Partial1").ToList());
            var _Partial2 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(AllmainPage.Where(x => x.Place == "_Partial2").ToList());
            var _Partial3 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(AllmainPage.Where(x => x.Place == "_Partial3").ToList());

            //AllmainPage.Result.Where(x=> x.Place== "_Partial1").ToList(),
            MainPage mainPage = new MainPage()
            {
                _Partial1= _Partial1,
                _Partial2= _Partial2,
                _Partial3= _Partial3,
                //_PartialCard2= _PartialCard2,
                
            };


            return View(mainPage);
        }
        //public void Base64ToImage(string source)
        //{
        //    string base64 = source.Substring(source.IndexOf(',') + 1);
        //    base64 = base64.Trim('\0');
        //    byte[] chartData = Convert.FromBase64String(base64);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
