using AutoMapper;
using Core.Contract;
using Core.Domian;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Pattern;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace ENDPOINT.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsyncPruductRepo _RepoPrc;
        private readonly IMapper _mapper;

        public HomeController(IAsyncPruductRepo pruduct, IMapper _mapper1)
        {
            _RepoPrc = pruduct;
            _mapper = _mapper1;
        }
        public IActionResult Index()
        {
            var mainPageobj = MainPageSingleton.GetInstance(_RepoPrc, _mapper);
            return View(mainPageobj);
        }
        public void ResetMain()
        {
            MainPageSingleton.DoItNull();
        }

    }
}

