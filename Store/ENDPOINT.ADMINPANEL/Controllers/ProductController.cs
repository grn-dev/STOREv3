﻿using System;
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

        //public async Task<IActionResult> Index()
        //{
        //    var productsawait = await productRepository.GetAllAsync();
        //    var products= productsawait.OrderByDescending(c => c.ProductID);

        //    foreach (var item in products)
        //    {
        //        item.Description = (item.Description.Length > 10) ? item.Description.Substring(0, 10) : item.Description;
        //    }

        //    return View(products);
        //}

        public IActionResult Index()
        {
            //var productsawaitsd = productRepository.GetAsync(102);
            var productsawait = productRepository.GetAll();
             
            return View(productsawait.ToList());
        }



        //ProuductID

        public string GetTag(int ProuductID)
        {
            var reds = ProductInfoRepository.GetMoreInfo(ProuductID, "tag");

            var jsonR = Newtonsoft.Json.JsonConvert.SerializeObject(reds);


            return jsonR;

        }

        public HttpResponseMessage DeleteProduct(int ProuductID)
        {
            productRepository.Delete(ProuductID);
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
        [HttpPost]
        public async Task<HttpResponseMessage> EditDescripon(int ProuductID, string Descripon = "")
        {
            var res=await productRepository.GetAsync(ProuductID);
            var Length = Descripon.Length;
            res.Description = Descripon;

            productRepository.Update(res);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        public IActionResult Add()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                CategoryForDisplay = categoryRepository.GetCategorylevel2().ToList(),
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
                    //isShow = true,
                    //count = 0,
                    //Price = 0,


                };
                string MainImages_;
                using (var ms = new MemoryStream())
                {
                    model.MainImages.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    MainImages_ = "data:image/jpeg;base64," + Convert.ToBase64String(fileBytes);

                }
                product.mainImages = MainImages_;
                List<ImageProduct> imgeProductsList = new List<ImageProduct>();
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
                            ImageProduct imageValue = new ImageProduct()
                            {
                                image = image_strine
                            };
                            imgeProductsList.Add(imageValue);
                        }

                    }

                }

                product.imageProducts = imgeProductsList;
                productRepository.Add(product);
                //iimgeProduct.AddList(imgeProductsList);
                return RedirectToAction("Index");
            }
            model.CategoryForDisplay = categoryRepository.GetCategorylevel2().ToList();
            return View(model);
        }


        
        public IActionResult relatedproducts()
        {
            var allprd = productRepository.GetAll().Select(c => new ProductReleted()
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
        public async Task<IActionResult> relatedproducts(RelatedProductsViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.MainProductID == model.RelatedProductID)
                        throw new Exception("محصولات انتخاب شده یکی میباشد");

                    if (ProductInfoRepository.CheckExist(model.MainProductID, "RelatedProduct", model.RelatedProductID.ToString()))
                        throw new Exception("قبلا ثبت شده است");




                    ProductInfo productInfo = new ProductInfo()
                    {
                        key = "RelatedProduct",
                        productID = model.MainProductID,
                        Value = model.RelatedProductID.ToString(),

                    };

                    await ProductInfoRepository.AddAsync(productInfo);

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

            var allprd = productRepository.GetAll().Select(c => new ProductReleted()
            {
                ProductID = c.ProductID,
                ProductName = c.Name
            }).ToList();
            model.ProductForDisplay = allprd;
            return View(model);
        }

    }
}
