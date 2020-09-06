using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework.App.InMemoryDataBase;
using Homework.App.Models;
using Homework.App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework.App.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult List()
        {
            var productList = new List<Product>();
            foreach (var product in Database.Products)
            {
                productList.Add(product);
            }
            return View(productList);
        }

        public IActionResult AddProduct()
        {
            AddProductVM addProduct = new AddProductVM();
            return View(addProduct);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductVM addProductVM)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product
                {
                    Name = addProductVM.Name,
                    Price = addProductVM.Price,
                    Category = addProductVM.Category,
                    Description = addProductVM.Description
                };
                Database.Products.Add(newProduct);
                return Redirect("/Product");
            }
            return View(addProductVM);
        }
    }
}
