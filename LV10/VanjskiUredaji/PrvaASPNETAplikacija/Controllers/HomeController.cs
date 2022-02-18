using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrvaASPNETAplikacija.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PrvaASPNETAplikacija.Controllers
{
    

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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



        [HttpPost]
        public void SaveImage(string base64image)
        {
            int x = 0;
            //System.IO.File.WriteAllText(Server.MapPath("~/Content/Images/" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt"), base64image);
        }
    }
}
