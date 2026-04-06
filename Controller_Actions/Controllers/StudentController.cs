using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Name = "John";
        ViewBag.Age = 22;
        return View();
    }

    
}