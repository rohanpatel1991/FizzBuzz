using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Fizzbuzz.Models;

namespace Fizzbuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public IActionResult Index(string TxtValue)
       {
           decimal ot = 0;
           bool o = TxtValue != null && decimal.TryParse(TxtValue, out ot);
           if (o)
            {
                    var n = Convert.ToInt32(TxtValue);
                    if (n % 15 == 0)
                    {
                        ViewData["Message"] = "FizzBuzz";
                        return View(ViewData);
                    }
                    else if (n % 5 == 0)
                    {
                        ViewData["Message"] = "Buzz";
                        return View(ViewData);
                    }
                    else if (n % 3 == 0)
                    {
                        ViewData["Message"] = "Fizz";
                        return View(ViewData);
                    }
                    else
                    {
                        ViewData["Message"] = "Divided " + n + " by 3" + "Divided " + n + " by 5";
                        return View(ViewData);
                    }
                
            }
            ViewData["Message"] = "Invalid item";
            return View(ViewData);
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