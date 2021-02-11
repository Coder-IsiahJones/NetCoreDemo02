using Bogus;
using NetCoreDemo02.Models;
using System;
using System.Collections.Generic;

namespace NetCoreDemo02.Services
{
    public class HardCodedSampleDataRepo : IProductDataService
    {
        private static List<ProductModel> productList = new List<ProductModel>();

        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productList.Count == 0)
            {
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
            }
            return productList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}