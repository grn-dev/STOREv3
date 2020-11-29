using Core.Contract;
using ENDPOINT.WEBUI.Models;
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
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IPruductRepo RepoPrc;
        public HomeController(IPruductRepo pruduct)
        {
            RepoPrc = pruduct;
        }

        public IActionResult Index()
        {
            var allp = RepoPrc.imgeForsingle();
            List<productSingleImage> singleList = new List<productSingleImage>();
            foreach (var item in allp)
            {
                productSingleImage singleImage = new productSingleImage
                {
                    CategoryId = item.CategoryId,
                    Category = item.Category,
                    Description = item.Description,
                    ImageFuckin = item.Images[0],
                    Name = item.Name,
                    id= item.ProductID

                };
                singleList.Add(singleImage);
            }
            return View(singleList);
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
