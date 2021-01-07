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
    [Authorize]
    public class ProductController : Controller
    {


        private readonly IAsyncCategoriRepo categoryRepository;
        private readonly IAsyncPruductRepo productRepository;
        private readonly IAsyncImageValue iimgeProduct;
        private readonly IAsyncProductInfo ProductInfoRepository;

        public ProductController(IAsyncCategoriRepo categoryRepository, IAsyncPruductRepo productRepository, IAsyncImageValue iimgeProduct_, IAsyncProductInfo ProductInfo_)
        {
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;
            this.iimgeProduct = iimgeProduct_;
            this.ProductInfoRepository = ProductInfo_;
        }

        public IActionResult Index()
        {
            var products = productRepository.GetAllAsync().Result.OrderByDescending(c => c.ProductID).ToList();

            foreach (var item in products)
            {
                item.Description = (item.Description.Length > 10) ? item.Description.Substring(0, 10) : item.Description;
            }

            return View(products);
        }

        //[AllowAnonymous]



        //ProuductID

        public string GetTag(int ProuductID)
        {
            var reds = ProductInfoRepository.GetMoreInfoAsync(ProuductID, "tag");

            var jsonR = Newtonsoft.Json.JsonConvert.SerializeObject(reds);


            return jsonR;

        }

        public HttpResponseMessage DeleteProduct(int ProuductID)
        {
            productRepository.DeleteAsync(ProuductID);
            return new HttpResponseMessage(HttpStatusCode.OK);
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

            ProductInfoRepository.AddAsync(productInfo);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        public IActionResult Add()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                CategoryForDisplay = categoryRepository.GetAllAsync().Result.ToList()
            };
            return View(model);
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
                string MainImages_;
                using (var ms = new MemoryStream())
                {
                    model.MainImages.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    MainImages_ = "data:image/jpeg;base64," + Convert.ToBase64String(fileBytes);

                }
                product.mainImages = MainImages_;
                List<ImageValue> imgeProductsList = new List<ImageValue>();
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
                            ImageValue imageValue = new ImageValue()
                            {
                                image = image_strine
                            };
                            imgeProductsList.Add(imageValue);
                        }

                    }

                }

                product.Images = imgeProductsList;
                productRepository.AddAsync(product);
                //iimgeProduct.AddList(imgeProductsList);
                return RedirectToAction("Index");
            }
            model.CategoryForDisplay = categoryRepository.GetAllAsync().Result.ToList();
            return View(model);
        }





        public IActionResult relatedproducts()
        {
            var allprd = productRepository.GetAllAsync().Result.Select(c => new ProductReleted()
            {
                ProductID = c.ProductID,
                ProductName = c.Name
            }).ToList();

            RelatedProductsViewModel model = new RelatedProductsViewModel
            {
                ProductForDisplay = allprd,

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult relatedproducts(RelatedProductsViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.MainProductID == model.RelatedProductID)
                        throw new Exception("محصولات انتخاب شده یکی میباشد");

                    if (ProductInfoRepository.CheckExistAsync(model.MainProductID, "RelatedProduct", model.RelatedProductID.ToString()))
                        throw new Exception("قبلا ثبت شده است");




                    ProductInfo productInfo = new ProductInfo()
                    {
                        key = "RelatedProduct",
                        productID = model.MainProductID,
                        Value = model.RelatedProductID.ToString(),

                    };

                    ProductInfoRepository.AddAsync(productInfo);

                }
                else
                {

                    var errors = ModelState.Select(x => x.Value.Errors)
                               .Where(y => y.Count > 0)
                               .ToList();


                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;

            }

            var allprd = productRepository.GetAllAsync().Result.Select(c => new ProductReleted()
            {
                ProductID = c.ProductID,
                ProductName = c.Name
            }).ToList();
            model.ProductForDisplay = allprd;
            return View(model);
        }

    }
}
