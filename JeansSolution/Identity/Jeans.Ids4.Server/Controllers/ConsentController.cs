using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.Ids4.Server.Controllers
{
    public class ConsentController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(string returnUrl)
        {
            return View("Error");
        }
    }
}
