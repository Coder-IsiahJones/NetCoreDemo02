﻿using Microsoft.AspNetCore.Mvc;
using NetCoreDemo02.Models;
using NetCoreDemo02.Services;
using System.Collections.Generic;

namespace NetCoreDemo02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //HardCodedSampleDataRepo hardCodedSampleDataRepo = new HardCodedSampleDataRepo();

            ProductsDAO products = new ProductsDAO();

            return View(products.GetAllProducts());
        }

        public IActionResult SearchResult(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();

            List<ProductModel> productList = products.SearchProducts(searchTerm);

            return View("index", productList);
        }

        public IActionResult SearchForm()
        {
            return View();
        }
    }
}