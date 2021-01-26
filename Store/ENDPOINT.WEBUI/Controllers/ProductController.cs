using AutoMapper;
using Core.Contract;
using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;
using EndPoints.WebUI.Models.Commons;
using Infrastructures.Dal;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ENDPOINT.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAsyncPruductRepo RepoPrc;
        private readonly IAsyncCategoriRepo categoriRepo;
        private readonly IAsyncProductInfo ProductInfoREPO;
        private readonly IMapper _mapper;
        int TafazolReleted = 0;
        bool FirstReleted = false;

        public ProductController(IAsyncPruductRepo RepoPrc_, IMapper mapper, IAsyncCategoriRepo categoriRepo_, IAsyncProductInfo ProductInfoREPO_)
        {
            RepoPrc = RepoPrc_;
            categoriRepo = categoriRepo_;
            ProductInfoREPO = ProductInfoREPO_;
            _mapper = mapper;

        }
        //https://stackoverflow.com/questions/30566848/when-should-i-use-async-controllers-in-asp-net-mvc
        public IActionResult shows(int ProductID)
        {

            Product res = RepoPrc.GetSingleProduct(ProductID);
            var TAGS = ProductInfoREPO.GetMoreInfo(ProductID, "TAG");
            var relerted = RepoPrc.GetReletionPruduct(ProductID);
            //UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            //var relertedmap = _mapper.Map<productSingleImage>(relerted);
            var relertedmaps = _mapper.Map<List<Product>, List<productSingleImage>>(relerted.ToList());
            //Product res =await restask;
            productMultiImage image = new productMultiImage()
            {
                AllImages = res.imageProducts.Select(x => x.image).ToList(),
                Category = res.Category,
                Description = res.Description,
                id = res.ProductID,
                Name = res.Name,
                Tags = TAGS,
                RelatedProduct = relertedmaps

            };
            image.AllImages.Add(res.mainImages);
            return View("showSingle", image);
        }

        public async Task<IActionResult> sc(string Input, int pn = 1)
        {
            int showpage = 6;
            IEnumerable<Product> pr;
            pr = await RepoPrc.GetProductsAsync(showpage, pn, Input);
            var level2 = categoriRepo.GetCategorylevel2Async(Input).ToList();
            //List<productSingleImage> singleImagesList = new List<productSingleImage>();
            // pr;
            if (pr.Count() <= 0)
            {
                pr = await RepoPrc.GetProductsbyParentcategoriAsync(showpage, pn, Input);
                //singleImagesList = _mapper.Map<List<Product>, List<productSingleImage>>(pr.ToList());
            } 

            PagingInfo pagin = new PagingInfo
            {
                CurrentPage = pn,
                TotalItems = RepoPrc.TotalCount(Input)+ RepoPrc.TotalCountlvl2(Input),
                ItemsPerPage = showpage

            };
            ProductsListViewModel productsListViewModel = new ProductsListViewModel()
            {
                Products = _mapper.Map<List<Product>, List<productSingleImage>>(pr.ToList()),
                Current = Input,
                PagingInfo = pagin,
                fromContoller = "sc",
                CategoryChild = level2,

            };


            return View("showListproduct", productsListViewModel);

        }


        public async Task<IActionResult> Seachq(string Input, int pn = 1)
        {
            int showpage = 6;
            
            

            IEnumerable<Product> ProductTAGS = new List<Product>();
            IEnumerable<Product> pr = await RepoPrc.GetProductsSearchAsync(showpage, pn, Input);
            //List<Product> prlis = await RepoPrc.GetProductsSearchAsync(showpage, pn, Input);
            if (RepoPrc.TotalCountSearch(Input)/ showpage < pn)
            {
                if (!FirstReleted)
                {
                    TafazolReleted = pn;
                    FirstReleted = true;
                }

                 
                //int TafazolPage = pn;
                //ProductTAGS = ProductInfoREPO.GetProductByTag(showpage, Tagpn, Input);
                ProductTAGS = await ProductInfoREPO.GetProductByTagAsync(showpage, pn- RepoPrc.TotalCountSearch(Input)/ showpage, Input);
                //prlis.InsertRange()
                //ProductTAGS = resr.ToList;
                //ProductTAGS= _mapper.Map<Product, GetProductByTag>(resProductTAGS);
                /// this.Database.SqlQuery<YourEntityType>("storedProcedureName",params);
            }


            List<productSingleImage> singleImagesList = new List<productSingleImage>();
            foreach (var item in pr)
            {
                singleImagesList.Add(
                    new productSingleImage()
                    {
                        mainImages = item.mainImages,
                        Category = item.Category,
                        Description = item.Description,
                        Name = item.Name,
                        ProductID = item.ProductID

                    }
                     );

            }
            foreach (var item in ProductTAGS)
            {
                singleImagesList.Add(
                    new productSingleImage()
                    {
                        mainImages = item.mainImages,
                        //Category = item.Category,
                        Description = item.Description,
                        Name = item.Name,
                        ProductID = item.ProductID

                    }
                     );

            }
            PagingInfo pagin = new PagingInfo
            {
                CurrentPage = pn,
                TotalItems = RepoPrc.TotalCountSearch(Input)+ ProductInfoREPO.TotalCountSearchTag(Input),
                ItemsPerPage = showpage

            };
            ProductsListViewModel productsListViewModel = new ProductsListViewModel()
            {
                Products = singleImagesList,
                Current = Input,
                PagingInfo = pagin,
                fromContoller = "Seachq"

            };
            return View("showListproduct", productsListViewModel);
            //TempData["productsListViewModel"] = JsonConvert.SerializeObject(productsListViewModel);


            //return RedirectToAction("showListproduct", "Product", new { @pn = pn });
        }

        public async Task<IActionResult> showListproduct(int pn = 1)
        {

            var productsListViewModel = JsonConvert.DeserializeObject<ProductsListViewModel>((string)TempData["productsListViewModel"]);
            ProductsListViewModel listViewModel = (ProductsListViewModel)TempData["productsListViewModel"];

            return View(listViewModel);
        }

        

    }
}
