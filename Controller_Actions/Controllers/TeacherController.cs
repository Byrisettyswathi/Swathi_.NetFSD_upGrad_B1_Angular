using Microsoft.AspNetCore.Mvc;

public class TeacherController : Controller
{
    public string Index()
    {
        return "Teacher Home Page";
    }

    public string Details()
    {
        return "Teacher Details Page";
    }
}