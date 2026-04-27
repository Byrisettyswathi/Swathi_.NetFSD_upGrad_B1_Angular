using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public string Index()
    {
        return "Welcome to ASP.NET Core MVC";
    }

    public string About()
    {
        return "This is About Page";
    }

    public string Contact()
    {
        return "Contact us at support@test.com";
    }
}