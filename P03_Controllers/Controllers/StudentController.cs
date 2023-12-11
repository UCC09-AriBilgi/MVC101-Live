using Microsoft.AspNetCore.Mvc;

namespace P03_Controllers.Controllers
{
    public class StudentController : Controller
    {
        // Action Metotları
        public string GetAll()
        {
            return "--- Tüm öğrenciler ---";
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
