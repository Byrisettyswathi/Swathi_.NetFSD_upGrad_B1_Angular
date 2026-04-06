
using EFCore_MVC_Assignment.Database;
using EFCore_MVC_Assignment.Entity;

using EFCore_MVC_Assignment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_MVC_Assignment.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountRepository _repo;

        // Constructor
        public AccountController()
        {
            _repo = new AccountRepository(); 
        }

        //  Get All Accounts
        public IActionResult Index()
        {
            var accounts = _repo.GetAccounts();
            return View(accounts);
        }

        //  GET: Create
        public IActionResult Create()
        {
            return View();
        }

        //  POST: Create
        [HttpPost]
        public IActionResult Create(Account account)
        {
            _repo.AddAccount(account);
            return RedirectToAction("Index");
        }

        //  Details
        public IActionResult Details(int id)
        {
            var account = _repo.GetAccount(id);
            return View(account);
        }

        //  GET: Edit
        public IActionResult Edit(int id)
        {
            var account = _repo.GetAccount(id);
            return View(account);
        }

        //  POST: Edit
        [HttpPost]
        public IActionResult Edit(Account account)
        {
            _repo.UpdateAccount(account);
            return RedirectToAction("Index");
        }

        // 🔹 GET: Delete
        public IActionResult Delete(int id)
        {
            var account = _repo.GetAccount(id);
            return View(account);
        }

        //  POST: Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var account = _repo.GetAccount(id);
            if (account != null)
            {
                _repo.DeleteAccount(account);
            }
            return RedirectToAction("Index");
        }
    }
}