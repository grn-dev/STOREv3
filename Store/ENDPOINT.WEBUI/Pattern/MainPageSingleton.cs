using AutoMapper;
using Core.Contract;
using Core.Domian;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Pattern
{
    public class MainPageSingleton
    {
        private static MainPage _instance;
        private static IAsyncPruductRepo RepoPrc;
        //private static IMapper _mapper;
        private MainPageSingleton()//IAsyncPruductRepo RepoPrc_, IMapper _mapper1)
        {
            //RepoPrc = RepoPrc_;
            //_mapper = _mapper1;
        }

        public static MainPage GetInstance(IAsyncPruductRepo RepoPrc_, IMapper _mapper)
        {
            if (_instance == null)
            {
                //new MainPageSingleton();
                _instance = new MainPage()
                {
                    _Partial1 = _mapper.Map<List<Product>, List<productSingleImage>>
                      ((RepoPrc_.GetProductmainPagev2("_Partial1")).ToList()),

                    _Partial2 = _mapper.Map<List<Product>, List<productSingleImage>>
                      ((RepoPrc_.GetProductmainPagev2("_Partial2")).ToList()),

                    _Partial3 = _mapper.Map<List<Product>, List<productSingleImage>>
                      ((RepoPrc_.GetProductmainPagev2("_Partial3")).ToList()),

                };
            }
            return _instance;
        }

        public static void DoItNull()
        {
            _instance = null;
        }
    }
}
