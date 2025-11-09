using Microsoft.AspNetCore.Mvc;
using SimpleMeetingApp.Models;

namespace SimpleMeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            //ViewBag.Selamla = saat > 12 ? "İyi Günlers" : "Günaydın";
            //ViewBag.Username = "eyupcelix7";
            ViewData["Selamla"] = saat > 12 ? "İyi günler aga" : "Günaydın hacı";
            ViewData["Username"] = "eyupcelix7";

            MeetingInfo info = new MeetingInfo
            {
                Id = 1,
                Location = "Istanbul",
                Date = DateTime.Now,
                NumberOfPeople = 4
            };

            return View(model: info);
        }
    }
}
