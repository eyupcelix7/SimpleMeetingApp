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
            ViewData["Selamla"] = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewData["Username"] = "eyupcelix7";

            int katilimciSayisi = Repository.Users.Count(x=> x.KatilimDurumu == true);

            MeetingInfo info = new MeetingInfo
            {
                Id = 1,
                Location = "Istanbul",
                Date = DateTime.Now,
                NumberOfPeople = katilimciSayisi
            };

            return View(model: info);
        }
    }
}
