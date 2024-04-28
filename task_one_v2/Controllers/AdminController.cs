using Microsoft.AspNetCore.Mvc;

namespace task_one_v2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
