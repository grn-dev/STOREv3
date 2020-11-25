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

        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the Image")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Please enter the Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter the Name")]
        public int CategoryId { get; set; }
        public List<Category> CategoryForDisplay { get; set; }
    }
}
