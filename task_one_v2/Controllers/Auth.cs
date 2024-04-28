using Microsoft.AspNetCore.Mvc;

namespace task_one_v2.Controllers
{
    public class Auth : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        public IActionResult PrivicyPolicy()
        {
            return View();
        }
        public IActionResult TermsAndCondition()
        {
            return View();
        }
    }
}
