using Core.Contract;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;
using EndPoints.WebUI.Models.Commons;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace ENDPOINT.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IPruductRepo RepoPrc;
        private readonly ICategoriRepo categoriRepo;
        public ProductController(IPruductRepo RepoPrc_, ICategoriRepo categoriRepo_)
        {
            RepoPrc = RepoPrc_;
            categoriRepo = categoriRepo_;
        }

        public IActionResult showSingle(int ProductID)
        {

            var res = RepoPrc.GetSingleProduct(ProductID);
            productMultiImage image = new productMultiImage()
            {
                AllImages = res.Images,
                Category = res.Category,
                Description = res.Description,
                id = res.ProductID,
                Name = res.Name

            };

            return View(image);
        }

        public IActionResult showByCategori(string Input, int pn = 1)
        {
            int showpage = 2;
            var pr = RepoPrc.GetProducts(showpage, pn, Input).ToList();


            List<productSingleImage> singleImagesList = new List<productSingleImage>();
            foreach (var item in pr)
            {
                singleImagesList.Add(
                    new productSingleImage()
                    {
                        ImageFuckin = item.Images[0],
                        Category = item.Category,
                        Description = item.Description,
                        Name = item.Name,
                        id = item.ProductID

                    }
                     );

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
                fromContoller= "showByCategori"

            };

            
            return View("showListproduct", productsListViewModel);
              
        }


        public IActionResult showBySeach(string Input, int pn = 1)
        {
            int showpage = 6;
            var pr = RepoPrc.GetProductsSearch(showpage, pn, Input).ToList();
            List<productSingleImage> singleImagesList = new List<productSingleImage>();
            foreach (var item in pr)
            {
                singleImagesList.Add(
                    new productSingleImage()
                    {
                        ImageFuckin = item.Images[0],
                        Category = item.Category,
                        Description = item.Description,
                        Name = item.Name,
                        id = item.ProductID

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
            ProductsListViewModel listViewModel= (ProductsListViewModel)TempData["productsListViewModel"];

            return View(listViewModel);
        }

    }
}
