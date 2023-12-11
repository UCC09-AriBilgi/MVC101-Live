using Microsoft.AspNetCore.Mvc;
using P01_MVCBasics.Models;
using System.Diagnostics;

namespace P01_MVCBasics.Controllers
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
            return View(); // Yani bir View'a git...'Index.cshtml
        }

        public IActionResult Privacy()
        {
            return View(); // Privacy.cshtml...yönlendirecek
        }

        public IActionResult Contact()
        {
            return View(); // Privacy.cshtml...yönlendirecek
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
