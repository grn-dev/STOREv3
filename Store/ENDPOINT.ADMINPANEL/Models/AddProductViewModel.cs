using Core.Domian;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.UI.panelAdmin.Models
{
    public class AddProductViewModel
    {

        [Required(ErrorMessage = "لطفا نام را وارد نمایید")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا Description را وارد نمایید")]
        public string Description { get; set; }

        [Required(ErrorMessage = "لطفا Images را وارد نمایید")]
        public List<IFormFile> Images { get; set; }

        //[Required(ErrorMessage = "Please enter the Price")]
        //public decimal Price { get; set; }

        [Required(ErrorMessage = "لطفا دسته بندی را وارد نمایید")]
        public int CategoryId { get; set; }
        public List<Category> CategoryForDisplay { get; set; }
    }
 
}
