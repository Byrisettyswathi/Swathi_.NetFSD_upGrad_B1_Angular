using Microsoft.AspNetCore.Mvc;

namespace Controller_Actions.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "John";
            ViewData["Age"] = 25;
            return View();
        }
    }
}
