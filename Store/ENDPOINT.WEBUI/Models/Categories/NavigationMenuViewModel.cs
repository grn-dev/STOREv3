using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoints.WebUI.Models.Categories
{
    public class NavigationMenuViewModel
    {
        public List<Category> Categorieslevel1 { get; set; }
        public List<Category> Categorieslevel2 { get; set; }
        public string CurentCategory { get; set; }
    }
}
