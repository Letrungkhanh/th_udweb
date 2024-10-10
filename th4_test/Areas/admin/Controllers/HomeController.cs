using Microsoft.AspNetCore.Mvc;

namespace th4_test.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
