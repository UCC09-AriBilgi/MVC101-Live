using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace P03_Controllers.Controllers
{
    public class StudentController : Controller
    {
        // Action Metotları
        public string GetAll()
        {
            return "--- Tüm öğrenciler ---";
        }
        public string GetOneStudent(string name)
        {
            return $"Kayıdını istemiş olduğunuz öğrenci : {name}";
        }

        public string Topla(int sayi1,int sayi2) 
        {
            int sonuc;

            sonuc=sayi1+sayi2;
            
            return $"Toplam sonucu : {sonuc.ToString()}";
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
