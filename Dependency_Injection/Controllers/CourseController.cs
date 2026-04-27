using Microsoft.AspNetCore.Mvc;
using Dependency_Injection.Entity;
using Dependency_Injection.Repositories;

namespace Dependency_Injection.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _repo;

        public CourseController(ICourseRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var courses = _repo.GetAll();
            return View(courses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }

        public IActionResult Edit(int id)
        {
            var course = _repo.GetById(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Course course)
        {
            _repo.Update(course);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var course = _repo.GetById(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}