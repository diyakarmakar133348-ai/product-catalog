using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using productcatalog.Models;

namespace productcatalog.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "HP Laptop",
                    Price = 55000,
                    Quantity = 10
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 25000,
                    Quantity = 15
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 2000,
                    Quantity = 20
                }
            };

            return View(products);
        }
    }
}