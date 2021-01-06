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

namespace ENDPOINT.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IPruductRepo RepoPrc;
        private readonly ICategoriRepo categoriRepo;
        private readonly IProductInfo ProductInfoREPO;
        private readonly IMapper _mapper;

        public ProductController(IPruductRepo RepoPrc_, IMapper mapper, ICategoriRepo categoriRepo_, IProductInfo ProductInfoREPO_)
        {
            RepoPrc = RepoPrc_;
            categoriRepo = categoriRepo_;
            ProductInfoREPO = ProductInfoREPO_;
            _mapper = mapper;
            
        }

        public IActionResult showSingle(int ProductID)
        {

            var res = RepoPrc.GetSingleProduct(ProductID);
            List<string> TAGS = ProductInfoREPO.GetMoreInfo(ProductID, "TAG");
            var relerted = RepoPrc.GetReletionPruduct(ProductID);
            //UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            //var relertedmap = _mapper.Map<productSingleImage>(relerted);

            var relertedmaps = _mapper.Map<List<Product>, List<productSingleImage>>(relerted);
            productMultiImage image = new productMultiImage()
            {
                AllImages = res.Images.Select(x => x.image).ToList(),// [0].image,
                Category = res.Category,
                Description = res.Description,
                id = res.ProductID,
                Name = res.Name,
                Tags = TAGS,
                RelatedProduct = relertedmaps

            };
            image.AllImages.Add(res.mainImages);
            return View(image);
        }

        public IActionResult showByCategori(string Input, int pn = 1)
        {
            int showpage = 6;
            var pr = RepoPrc.GetProducts(showpage, pn, Input).ToList();
            var level2 = categoriRepo.GetCategorylevel2(Input).ToList();
            List<productSingleImage> singleImagesList = new List<productSingleImage>();

            if (pr.Count > 0)
            {
                singleImagesList = _mapper.Map<List<Product>, List<productSingleImage>>(pr);
            }
            else
            {
                //if (level2 != null && pr.Count <= 0)
                //{
                //    var pr23 = RepoPrc.GetProducts(showpage, pn, Input).ToList();
                //}
                //var pr2 = RepoPrc.GetProductsbyParentcategori(showpage, pn, Input).ToList();
                //singleImagesList = _mapper.Map<List<Product>, List<productSingleImage>>(pr2);
            }

            PagingInfo pagin = new PagingInfo
            {
                CurrentPage = pn,
                TotalItems = RepoPrc.TotalCount(Input),
                ItemsPerPage = showpage

            };
            ProductsListViewModel productsListViewModel = new ProductsListViewModel()
            {
                Products = singleImagesList,
                Current = Input,
                PagingInfo = pagin,
                fromContoller = "showByCategori",
                CategoryChild = level2

            };


            return View("showListproduct", productsListViewModel);

        }


        public IActionResult showBySeach(string Input, int pn = 1)
        {




            int showpage = 6;
            List<GetProductByTag> ProductTAGS = new List<GetProductByTag>();
            List<Product> pr = RepoPrc.GetProductsSearch(showpage, pn, Input).ToList();
            if (pr.Count < 6)
            {
                int Tagpnfirst = pn;
                int Tagpn = 1;
                //int TafazolPage = pn;
                //ProductTAGS = ProductInfoREPO.GetProductByTag(showpage, Tagpn, Input);
                ProductTAGS = ProductInfoREPO.GetProductByTag(showpage, Tagpn, Input);
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
                TotalItems = RepoPrc.TotalCountSearch(Input),
                ItemsPerPage = showpage

            };
            ProductsListViewModel productsListViewModel = new ProductsListViewModel()
            {
                Products = singleImagesList,
                Current = Input,
                PagingInfo = pagin,
                fromContoller = "showBySeach"

            };
            return View("showListproduct", productsListViewModel);
            //TempData["productsListViewModel"] = JsonConvert.SerializeObject(productsListViewModel);


            //return RedirectToAction("showListproduct", "Product", new { @pn = pn });
        }

        public IActionResult showListproduct(int pn = 1)
        {

            var productsListViewModel = JsonConvert.DeserializeObject<ProductsListViewModel>((string)TempData["productsListViewModel"]);
            ProductsListViewModel listViewModel = (ProductsListViewModel)TempData["productsListViewModel"];

            return View(listViewModel);
        }

    }
}
