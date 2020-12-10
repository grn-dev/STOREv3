using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Core.Contract;
using Core.Domian;
using CORE.CONTRACT;
using CORE.DOMAIN.Entities;
using EndPoint.UI.panelAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoint.UI.panelAdmin.Controllers
{
    //[Authorize]
    public class ProductController : Controller
    {


        private readonly ICategoriRepo categoryRepository;
        private readonly IPruductRepo productRepository;
        private readonly IimgeProduct iimgeProduct;
        private readonly IProductInfo ProductInfo;

        public ProductController(ICategoriRepo categoryRepository, IPruductRepo productRepository, IimgeProduct iimgeProduct_, IProductInfo ProductInfo_)
        {
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;
            this.iimgeProduct = iimgeProduct_;
            this.ProductInfo = ProductInfo_;
        }

        public IActionResult Index()
        {
            var products = productRepository.GetAll().OrderByDescending(c => c.ProductID).ToList();

            foreach (var item in products)
            {
                item.Description = (item.Description.Length> 10) ? item.Description.Substring(0, 10) : item.Description;
            }
            
            return View(products);
        }

        //[AllowAnonymous]
        public IActionResult Add()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                CategoryForDisplay = categoryRepository.GetAll().ToList()
            };
            return View(model);
        }


        //ProuductID

        public string GetTag(int ProuductID)
        { 
            var reds=ProductInfo.GetMoreInfo(ProuductID, "tag");
              
            var jsonR=Newtonsoft.Json.JsonConvert.SerializeObject(reds);
             

            return jsonR;

        }

        [HttpPost]
        public HttpResponseMessage AddTag(int ProuductID, string tagneme = "")
        {

            ProductInfo productInfo = new ProductInfo()
            {
                key = "TAG",
                productID = ProuductID,
                Value = tagneme,

            };

            ProductInfo.Add(productInfo);
            return new HttpResponseMessage(HttpStatusCode.OK); 

        }

        [HttpPost]
        public IActionResult Add(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product
                {
                    CategoryId = model.CategoryId,
                    Description = model.Description,
                    Name = model.Name,
                    isShow = true,
                    count = 0,
                    Price = 0,

                };





                List<imgeProduct> imgeProductsList = new List<imgeProduct>();
                string image_strine = "";
                if (model?.Images?.Count > 0)
                {
                    foreach (var item in model.Images)
                    {
                        using (var ms = new MemoryStream())
                        {
                            item.CopyTo(ms);
                            var fileBytes = ms.ToArray();
                            image_strine = "data:image/jpeg;base64," + Convert.ToBase64String(fileBytes);

                        }
                        imgeProduct imgeProduct = new imgeProduct
                        {
                            Product = product,
                            image = image_strine,

                        };
                        imgeProductsList.Add(imgeProduct);

                    }

                }


                productRepository.Add(product);
                iimgeProduct.AddList(imgeProductsList);
                return RedirectToAction("Index");
            }
            model.CategoryForDisplay = categoryRepository.GetAll().ToList();
            return View(model);
        }
    }
}
