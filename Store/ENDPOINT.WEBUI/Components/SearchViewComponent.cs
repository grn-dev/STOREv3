using Core.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoints.WebUI.Components
{
    public class SearchViewComponent : ViewComponent
    {
        private readonly IPruductRepo _prcRepo;

        public SearchViewComponent(IPruductRepo repo)
        {
            _prcRepo = repo;
        }
        public IViewComponentResult Invoke()
        {
            //var model = new NavigationMenuViewModel
            //{
            //    Categories = _categoryRepository.GetAll().ToList(),

            //};
            //if (RouteData?.Values.ContainsKey("category") == true)
            //{
            //    model.CurentCategory = RouteData.Values["category"].ToString();
            //}
            return View();
        }
    }
}
