using Microsoft.AspNetCore.Mvc;
using P04_Views.Models;

namespace P04_Views.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Student student = new Student()
            {
                StudentId = 200,
                Name = "Ümit K",
                Phone = "12345678901",
                Email = "xx@yy.com",
                Gender = "E"
            };

            ViewData["StudentInfo"] = student;





            return View(ViewData["StudentInfo"]);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
