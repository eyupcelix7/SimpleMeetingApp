using Microsoft.AspNetCore.Mvc;

namespace SimpleMeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
