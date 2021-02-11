using Bogus;
using Microsoft.AspNetCore.Mvc;
using NetCoreDemo02.Models;
using NetCoreDemo02.Services;
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
            HardCodedSampleDataRepo hardCodedSampleDataRepo = new HardCodedSampleDataRepo();

            return View(hardCodedSampleDataRepo.GetAllProducts());
        }
    }
}
