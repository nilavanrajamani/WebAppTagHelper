using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTagHelperPrj.Models;

namespace WebAppTagHelperPrj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ModelAddress modelAddress = new ModelAddress();
            modelAddress.FirstName = "Peter";
            modelAddress.LastName = "Long";
            return View(modelAddress);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
