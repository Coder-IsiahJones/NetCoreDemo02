using NetCoreDemo02.Models;
using System.Collections.Generic;

namespace NetCoreDemo02.Services
{
    internal interface IProductDataService
    {
        List<ProductModel> GetAllProducts();

        List<ProductModel> SearchProducts(string searchTerm);

        ProductModel GetProductById(int id);

        int Insert(ProductModel product);

        int Delete(ProductModel product);

        int Update(ProductModel product);
    }
}