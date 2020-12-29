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
        private readonly IPruductRepo RepoPrc; 
        private readonly IMapper _mapper;
        public HomeController(IPruductRepo pruduct, IMapper _mapper1)
        {
            RepoPrc = pruduct;
            _mapper = _mapper1;
        }

        public IActionResult Index()
        {
            //var _PartialCard23 = RepoPrc.GetProductmainPage("_PartialCard2");
            //var _Partial13 = RepoPrc.GetProductmainPage("_Partial1");
            //var _Partial23 = RepoPrc.GetProductmainPage("_Partial2");
            //var _Partial33 = RepoPrc.GetProductmainPage("_Partial3");

            List<productSingleImageCore> Allmain = RepoPrc.GetProductmainPage();

            var artialCard2 = Allmain.Where(c => c.Place == "_PartialCard2").ToList();
            var artial1 = Allmain.Where(c => c.Place == "_Partial1").ToList();
            var artial2 = Allmain.Where(c => c.Place == "_Partial2").ToList();
            var artial3 = Allmain.Where(c => c.Place == "_Partial3").ToList();

            var _PartialCard2 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(artialCard2);
            var _Partial1 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(artial1);
            var _Partial2 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(artial2);
            var _Partial3 = _mapper.Map<List<productSingleImageCore>, List<productSingleImage>>(artial3);
            MainPage mainPage = new MainPage()
            {
                _Partial1 = _Partial1,
                _Partial2 = _Partial2,
                _Partial3 = _Partial3,
                _PartialCard2 = _PartialCard2,

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
