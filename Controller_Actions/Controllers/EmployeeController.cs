using Microsoft.AspNetCore.Mvc;

namespace Controller_Actions.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Ravi";
            ViewData["Salary"] = 50000;
            ViewData["Department"] = "IT";
            return View();
        }
    }
}
