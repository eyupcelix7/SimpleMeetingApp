using Microsoft.AspNetCore.Mvc;

namespace SimpleMeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
