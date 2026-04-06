using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    public string GetProduct(int id)
    {
        return $"Product Id is: {id}";
    }
}