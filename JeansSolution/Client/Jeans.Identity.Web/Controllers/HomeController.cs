using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Jeans.Identity.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HomeController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login()
        {
            //var cardClaims = new List<Claim>()
            //{
            //    new Claim(ClaimTypes.Name,"Jeans"),
            //    new Claim(ClaimTypes.Email,"lijiansoftware@163.com"),
            //    new Claim("QQ","185416672")
            //};

            //var driveClaims = new List<Claim>()
            //{
            //    new Claim("CardNumber","430621XXXXXXXXXXXX"),
            //    new Claim("DriveType","C1")
            //};

            //var cardIdentity = new ClaimsIdentity(cardClaims, "Cookie Card");
            //var driveIdentity = new ClaimsIdentity(driveClaims, "Cookie Drive");

            //var userPrincipal = new ClaimsPrincipal(new[] { cardIdentity, driveIdentity });

            //await HttpContext.SignInAsync(userPrincipal);

            //return RedirectToAction("PersonInfo");

            string username = "jeans";
            string password = "password";

            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("PersonInfo");
                }
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult PersonInfo()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> LoginOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Register()
        {
            string username = "jeans";
            string password = "password";

            var user = new IdentityUser
            {
                UserName = username,
                Email = "lijiansoftware@163.com"
            };

            var userResult = await _userManager.CreateAsync(user, password);
            if (userResult.Succeeded)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("PersonInfo");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
