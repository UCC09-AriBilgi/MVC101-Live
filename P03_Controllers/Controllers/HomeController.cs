using Microsoft.AspNetCore.Mvc;
using P03_Controllers.Models;
using System.Diagnostics;

// Controller lar aslında bir grup "action" adlandırdığımız sanki "OnClick" olayı gibi ...
// Yaptığı olay etrafı dinlemek(HTTP Request-istekler) buna göre ilgili yerlere yönlendirme yapmak(trafik polisi)


namespace P03_Controllers.Controllers
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
    }
}
