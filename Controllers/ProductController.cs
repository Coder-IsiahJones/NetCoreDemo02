using Bogus;
using Microsoft.AspNetCore.Mvc;
using NetCoreDemo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductModel> productList = new List<ProductModel>();

            productList.Add(new ProductModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A square piece of plastic to make mousing easier." });
            productList.Add(new ProductModel { Id = 2, Name = "Web Pad", Price = 6.99m, Description = "A square piece of plastic to make mousing easier." });
            productList.Add(new ProductModel { Id = 3, Name = "Cam Pad", Price = 7.99m, Description = "A square piece of plastic to make mousing easier." });
            productList.Add(new ProductModel { Id = 4, Name = "Toe Pad", Price = 8.99m, Description = "A square piece of plastic to make mousing easier." });

            // Bogus Example (Fake Data)
            for (int i = 0; i < 100; i++)
            {
                productList.Add(new Faker<ProductModel>()
                    .RuleFor(p => p.Id, i + 5)
                    .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                    .RuleFor(p => p.Description, f => f.Rant.Review())
                    );
            }

            return View(productList);
        }
    }
}
