using Homework.App.Models;
using Homework.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.App.InMemoryDataBase
{
    public static class Database
    {
        public static List<Product> Products;

        static Database()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    ProductID = 10, Name = "Football", Description = "White", Price = 25, Category = ProductCategory.Sport
                },
                new Product()
                {
                    ProductID = 15, Name = "Fight Club", Description = "We dont talk about Fight Club", Price = 150, Category = ProductCategory.Movies
                },
                new Product()
                {
                    ProductID = 12, Name = "TV", Description = "LED", Price = 75, Category = ProductCategory.Electronics
                }
            };
        }
    }
}
