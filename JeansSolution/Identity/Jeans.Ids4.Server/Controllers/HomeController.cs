using Microsoft.AspNetCore.Mvc;

namespace Jeans.Ids4.Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
