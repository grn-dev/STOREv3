using Infrastructures.Dal.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoints.WebUI.Models.Categories;
using Core.Contract;

namespace EndPoints.WebUI.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private readonly ICategoriRepo _categoryRepository;

        public NavigationMenuViewComponent(ICategoriRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var model = new NavigationMenuViewModel
            {
                Categories = _categoryRepository.GetAll().ToList(),

            };
            if (RouteData?.Values.ContainsKey("category") == true)
            {
                model.CurentCategory = RouteData.Values["category"].ToString();
            }
            return View(model);
        }
    }
}
