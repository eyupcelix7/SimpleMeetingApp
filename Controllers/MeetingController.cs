using Microsoft.AspNetCore.Mvc;
using SimpleMeetingApp.Models;

namespace SimpleMeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo user)
        {
            Console.WriteLine($"Adı: {user.Name}, Telefon Numarası: {user.Phone}, Email Adresi: {user.Email}, Katılım Durumu: {user.KatilimDurumu.ToString()}");
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}
