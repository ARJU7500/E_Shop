using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    public class StoreHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
