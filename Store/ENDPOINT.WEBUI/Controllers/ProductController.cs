using Core.Contract;
using ENDPOINT.WEBUI.Models;
using ENDPOINT.WEBUI.Models.Product;
using EndPoints.WebUI.Models.Commons;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult showByCategori(string Categori, int pn = 1)
        {
            int showpage = 12;
            var pr = RepoPrc.GetProducts(showpage, pn, Categori).ToList();


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
                TotalItems = RepoPrc.TotalCount(Categori),
                ItemsPerPage = showpage

            };
            return RedirectToAction("showListproduct", "Product", new { @productSingleImages = singleImagesList, @pagingInfoiInput = pagin, @pn = pn });
              
        }


        public IActionResult showBySeach(string productName, int pn = 1)
        {
            int showpage = 12;
            var pr = RepoPrc.GetProductsSearch(showpage, pn, productName).ToList();
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
                TotalItems = RepoPrc.TotalCountSearch(productName),
                ItemsPerPage = showpage

            };
            return RedirectToAction("showListproduct", "Product", new { @productSingleImages = singleImagesList, @pagingInfoiInput = pagin, @pn = pn });
        }

        public IActionResult showListproduct(List<productSingleImage> productSingleImages, PagingInfo pagingInfoiInput, int pn = 1)
        {

            int showpage = 12;
            ProductsListViewModel productsListViewModel = new ProductsListViewModel()
            {
                Products= productSingleImages,
                CurrentCategory=null,
                PagingInfo = pagingInfoiInput

            };
            TempData["searchJob"] = searchJob;
            return RedirectToAction...;

            return View(productsListViewModel);
        }

    }
}
