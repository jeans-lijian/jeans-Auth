using Jeans.WebCore.Models.Account;
using Jeans.WebCore.Resources;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Jeans.WebCore.Controllers
{
    public class AccountController : BaseController
    {
        //private readonly IUserService _userService;
        //public AccountController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;            

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!model.HasLogin())
            {
                ModelState.AddModelError("", Common.UserPwdError);

                return View(model);
            }           

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, model.UserName));

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToLocal(returnUrl);
        }

        [HttpGet]
        public async Task<IActionResult> LoginOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Login));
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}