using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Jeans.Cookie.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login()
        {
            var cardClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,"Jeans"),
                new Claim(ClaimTypes.Email,"lijiansoftware@163.com"),
                new Claim("QQ","185416672")
            };

            var driveClaims = new List<Claim>()
            {
                new Claim("CardNumber","430621XXXXXXXXXXXX"),
                new Claim("DriveType","C1")
            };

            var cardIdentity = new ClaimsIdentity(cardClaims, "Cookie Card");
            var driveIdentity = new ClaimsIdentity(driveClaims, "Cookie Drive");

            var userPrincipal = new ClaimsPrincipal(new[] { cardIdentity, driveIdentity });

            await HttpContext.SignInAsync(userPrincipal);

            return RedirectToAction("PersonInfo");
        }

        [Authorize]
        public IActionResult PersonInfo()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> LoginOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }
    }
}
