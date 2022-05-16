using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
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

        [HttpPost]
        public ActionResult Calculate(IFormCollection data)
        {
            //get Data From UI
            int fieldHeight = int.Parse(data["fieldHeight"]);
            int fieldWeight = int.Parse(data["fieldWeight"]);

            //身高轉公尺
            float h = (float)fieldHeight / 100;

            //計算BMI
            float BmiResult = fieldWeight / (h * h);
 
            //return to view
            ViewBag.Result = BmiResult;
            ViewBag.fieldHeight = fieldHeight;
            ViewBag.fieldWeight = fieldWeight;
            //show Page Index
            return View("Index");
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
