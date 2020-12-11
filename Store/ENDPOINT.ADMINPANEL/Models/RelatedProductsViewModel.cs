using Core.Domian;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EndPoint.UI.panelAdmin.Models
{
    public class RelatedProductsViewModel
    {

        [Required(ErrorMessage = "لطفا نام را وارد نمایید")]
        public int MainProductID { get; set; }



        [Required(ErrorMessage = "لطفا نام را وارد نمایید")]
        public int RelatedProductID { get; set; }



        public List<ProductReleted> ProductForDisplay { get; set; }
    }




    public class ProductReleted
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}


