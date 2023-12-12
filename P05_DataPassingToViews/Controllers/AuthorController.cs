using Microsoft.AspNetCore.Mvc;
using P05_DataPassingToViews.Models;

namespace P05_DataPassingToViews.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag
            // Controller --> View a veri taşımak için kullanılıyor.Tersi durum View--> Controller mümkün değil.
            // - Viewbag kullanımında sayfamızın bir refresh redirect türü işlemlerde (post işlemleri) içeriği temizlenir.
            // - eğer birden fazla aynı viewbag tanımlaması varsa en son tanımlanan geçerli oluyor.
            ViewBag.Message = "Bu bir ViewBag den gelen mesajdır...";

            // ViewData
            // Esas farkı backgroundda yani veriyi tutma şeklinde. Dictionary yapısı olarak veriyi tutuyor.(Key-Value eşleşmesi olarak)

            List<Authors> authorlist = new List<Authors>();

            authorlist.Add(new Authors() { AuthorID = 1, AuthorName = "Stephen King", BookName = "It" });
            authorlist.Add(new Authors() { AuthorID = 2, AuthorName = "Alexander Dumas", BookName = "Three Musketeers" }); 
            authorlist.Add(new Authors() { AuthorID = 3, AuthorName = "Seth Godin", BookName = "Mor İnek" });
            authorlist.Add(new Authors() { AuthorID = 4, AuthorName = "Seymen Bozaslan", BookName = "İçinden Yol Geçen Hayatlar" });
            authorlist.Add(new Authors() { AuthorID = 5, AuthorName = "Erkin Yeşil", BookName = "Türkiye'nin Macera Rotaları" }); 
            authorlist.Add(new Authors() { AuthorID = 6, AuthorName = "Ayşegül Karaçivi", BookName = "Getirin Çekicimi...Kırılacak Kabuk Var" });

            ViewBag.Message = "Bu ViewData ile taşınan bir veridir..";

            ViewData["Authors"] = authorlist;

            return View();
        }
    }
}
