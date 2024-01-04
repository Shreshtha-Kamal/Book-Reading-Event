using BookReadingEventApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;


namespace BookReadingEventApplicationCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService userService;

        public LoginController(IUserService userService )
        {
            this.userService = userService;
        }




        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Create
        public IActionResult Login()
        {
            return View("Login");
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Services.Models.User user = new Services.Models.User()
            {
                Email = login.Email,
                Password = login.Password
            };
            if (userService.Login(user))
            {
                var userID = userService.GetUserID(user.Email);
                var roles = userService.GetRole(user.Email);
                HttpContext.Session.SetString("IsLoggedIn", "true");
                HttpContext.Session.SetInt32("UserID", userID);
                HttpContext.Session.SetString("Role", roles);
                if (roles.Equals("Admin"))
                {
                    return RedirectToAction("AllEvents", "Home");

                }
                return RedirectToAction("Index","Home");
            }
            else
            {

                ModelState.AddModelError("Password", "Invalid Email address or Password....!!");
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsLoggedIn");
            return RedirectToAction("Index" , "Home");

        }

        
    }
}
