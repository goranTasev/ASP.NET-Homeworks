using Homework.App.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.App.Models.ViewModels
{
    public class AddProductVM
    {
        [Display(Name = "Product name")]
        [Required(ErrorMessage = "You must give your product a name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "You must give your product a price")]
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
        public List<SelectListItem> ProductCategory1 { get; set; }

        public AddProductVM()
        {
            ProductCategory1 = new List<SelectListItem>();

            ProductCategory1.Add(new SelectListItem
            {
                Value = ((int)ProductCategory.Sport).ToString(),
                Text = ProductCategory.Sport.ToString()
            });
            ProductCategory1.Add(new SelectListItem
            {
                Value = ((int)ProductCategory.Electronics).ToString(),
                Text = ProductCategory.Electronics.ToString()
            });
            ProductCategory1.Add(new SelectListItem
            {
                Value = ((int)ProductCategory.Movies).ToString(),
                Text = ProductCategory.Movies.ToString()
            });
        }
    }
}
