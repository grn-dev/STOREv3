using Core.Domian;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace EndPoint.UI.panelAdmin.Models
{
    public class CategoriViewModel
    {
        public List<Category> categorieslvl1 { get; set; }
        //public List<CategoriShowViewModel> categorieslvl2 { get; set; }

        public int ParentId { get; set; }

        [Required(ErrorMessage = "لطفا نام دسته بندی را وارد نمایید")]
        public string newCategoriName { get; set; }
    }

    public class CategoriShowViewModel
    {
         
        public int ID { get; set; }
        public string Categori { get; set; }
    }
}


