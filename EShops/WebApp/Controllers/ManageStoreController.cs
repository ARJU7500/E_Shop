using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ManageStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
