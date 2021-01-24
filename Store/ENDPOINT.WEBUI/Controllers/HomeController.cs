using AutoMapper;
using Core.Contract;
using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;

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

            //Partial1();
            //Partial2();
            //Partial3();
            //return View();
            //var _PartialCard23 = RepoPrc.GetProductmainPage("_PartialCard2");
            //var _Partial13 = RepoPrc.GetProductmainPage("_Partial1");
            //var _Partial23 = RepoPrc.GetProductmainPage("_Partial2");
            //var _Partial33 = RepoPrc.GetProductmainPage("_Partial3");

            //string Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            //_logger.LogInformation(Message);


            ////var routeInfo = ControllerContext.ToCtxString(id);

            ////_logger.Log(LogLevel.Information, MyLogEvents.TestItem, routeInfo);
            ////_logger.LogInformation(MyLogEvents.TestItem, routeInfo);
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //TimeSpan ts2 = stopWatch.Elapsed;
            //_logger.LogInformation(ts2.TotalMilliseconds.ToString());

            /*var _Partial1 = await RepoPrc.GetProductmainPageAsync("_Partial1");
            var _Partial2 = await RepoPrc.GetProductmainPageAsync("_Partial2");
            var _Partial3 = await RepoPrc.GetProductmainPageAsync("_Partial3");*/

            /* var _Partial1temp = _mapper.Map<List<Product>, List<productSingleImage>>
                 ((await RepoPrc.GetProductmainPageAsync("_Partial1")).ToList());

             var _Partial2temp = _mapper.Map<List<Product>, List<productSingleImage>>
                 ((await RepoPrc.GetProductmainPageAsync("_Partial2")).ToList());

             var _Partial3temp = _mapper.Map<List<Product>, List<productSingleImage>>
                 ((await RepoPrc.GetProductmainPageAsync("_Partial3")).ToList());*/



            /*var _Partial1 =  RepoPrc.GetProductmainPageAsync("_Partial1");
            var _Partial2 =  RepoPrc.GetProductmainPageAsync("_Partial2");
            var _Partial3 =  RepoPrc.GetProductmainPageAsync("_Partial3");

            var _Partial1temp = _mapper.Map<List<Product>, List<productSingleImage>>(await _Partial1.Result.ToList());
            var _Partial2temp = _mapper.Map<List<Product>, List<productSingleImage>>(await _Partial2.ToList());
            var _Partial3temp = _mapper.Map<List<Product>, List<productSingleImage>>(await _Partial3.ToList());*/


            MainPage mainPage = new MainPage()
            {
                _Partial1 = _mapper.Map<List<Product>, List<productSingleImage>>
                ((RepoPrc.GetProductmainPagev2("_Partial1")).ToList()),//new List<productSingleImage>(),

                _Partial2 = _mapper.Map<List<Product>, List<productSingleImage>>
                (( RepoPrc.GetProductmainPagev2("_Partial2")).ToList()),//new List<productSingleImage>(),

                _Partial3 = _mapper.Map<List<Product>, List<productSingleImage>>
                ((RepoPrc.GetProductmainPagev2("_Partial3")).ToList()),//new List<productSingleImage>(),
                //_PartialCard2= _PartialCard2,

            };
            /*
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            _logger.LogInformation(ts.TotalMilliseconds.ToString());

            _logger.LogInformation("____________________________________");*/
            return View(mainPage);


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

