using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoints.WebUI.Models.Categories
{
    public class NavigationMenuViewModel
    {
        public List<Category> Categories { get; set; }
        public string CurentCategory { get; set; }
    }
}
