using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using Core.Domian;
using EndPoint.UI.panelAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoint.UI.panelAdmin.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {


        private readonly ICategoriRepo categoryRepository;
        private readonly IPruductRepo productRepository;

        public ProductController(ICategoriRepo categoryRepository, IPruductRepo productRepository)
        {
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = productRepository.GetAll().OrderByDescending(c=> c.ProductID).ToList();
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
                    Price = model.Price,
                    count=12,
                    isShow=true,
                    //Images
                    

                };
                if (model?.Image?.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        //product.Images = "data:image/jpeg;base64," + Convert.ToBase64String(fileBytes);
                    }
                }
                productRepository.Add(product);
                return RedirectToAction("Index");
            }
            model.CategoryForDisplay = categoryRepository.GetAll().ToList();
            return View(model);
        }
    }
}
