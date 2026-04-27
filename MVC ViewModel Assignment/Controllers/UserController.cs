using Microsoft.AspNetCore.Mvc;
using MVC_ViewModel_Assignment.Models;
using MVC_ViewModel_Assignment.ViewModels;
using Microsoft.AspNetCore.Http;


namespace MVC_ViewModel_Assignment.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();

        // REGISTER GET
        public IActionResult Register()
        {
            return View();
        }


        // REGISTER POST
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }


        // LOGIN GET
        public IActionResult Login()
        {
            return View();
        }


        // LOGIN POST
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                return RedirectToAction("Profile");
            }

            ViewBag.Error = "Invalid login";
            return View();
        }


        // PROFILE
        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(u => u.Email == email);

            var vm = new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };

            return View(vm);
        }


        // EDIT GET
        public IActionResult Edit()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(u => u.Email == email);
            return View(user);
        }


        // EDIT POST
        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Email == updatedUser.Email);

            if (user != null)
            {
                user.Name = updatedUser.Name;
                return RedirectToAction("Profile");
            }

            return View(updatedUser);
        }



        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}