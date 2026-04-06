using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    public string Details(string name, int age)
    {
        return $"Name: {name}, Age: {age}";
    }
}