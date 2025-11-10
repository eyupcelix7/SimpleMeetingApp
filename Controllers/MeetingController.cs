using Microsoft.AspNetCore.Mvc;
using SimpleMeetingApp.Models;

namespace SimpleMeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo user)
        {
            if(ModelState.IsValid)
            {
                //Console.WriteLine($"Adı: {user.Name}, Telefon Numarası: {user.Phone}, Email Adresi: {user.Email}, Katılım Durumu: {user.KatilimDurumu.ToString()}");
                Repository.CreateUser(user);
                ViewBag.PeopleCount = Repository.Users.Count(x => x.KatilimDurumu == true);
                return View("Thanks", model: user);
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult List()
        {
            List<UserInfo> users = Repository.Users;
            return View(users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
