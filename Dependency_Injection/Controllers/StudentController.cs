using Microsoft.AspNetCore.Mvc;
using Dependency_Injection.Entity;
using Dependency_Injection.Repositories;

namespace Dependency_Injection.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repo;

        public StudentController(IStudentRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var students = _repo.GetAll();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = _repo.GetById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _repo.Update(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = _repo.GetById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}