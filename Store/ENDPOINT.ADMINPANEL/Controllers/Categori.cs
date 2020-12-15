using Core.Contract;
using Core.Domian;
using EndPoint.UI.panelAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENDPOINT.ADMINPANEL.Controllers
{
    [Authorize]
    public class Categori : Controller
    {
        private readonly ICategoriRepo categoryRepository;

        public Categori(ICategoriRepo categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }


        public IActionResult Index()
        {
            var res = categoryRepository.GetAll().Select(s => new CategoriShowViewModel
            {
                Categori = s.CategoryName,
                ID = s.CategoryId
            }).ToList();
            //var res=categoryRepository.GetAll().Select(c=> c.CategoryId );
            CategoriViewModel resCategoriViewModel = new CategoriViewModel()
            {
                categories = res
            };

            return View(resCategoriViewModel);
        }


        [HttpPost]
        public IActionResult Index(CategoriViewModel categoriViewModel)
        {

            if (ModelState.IsValid)
            {


                Category Categori_ = new Category()
                {
                    CategoryName = categoriViewModel.newCategoriName,

                };

                if (categoriViewModel.ParentId == 0)
                {
                    Categori_.parentId = null;
                }
                else
                {
                    Categori_.parentId = categoriViewModel.ParentId;
                }

                categoryRepository.Add(Categori_);
                RedirectToAction("Index");

            }

            var res = categoryRepository.GetAll().Select(s => new CategoriShowViewModel
            {
                Categori = s.CategoryName,
                ID = s.CategoryId
            }).ToList();
            categoriViewModel.categories = res;
            return View(categoriViewModel);
        }
    }
}
