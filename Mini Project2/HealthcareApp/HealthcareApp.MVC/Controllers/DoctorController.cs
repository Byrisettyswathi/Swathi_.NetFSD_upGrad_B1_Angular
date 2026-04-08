using Microsoft.AspNetCore.Mvc;
using HealthcareApp.BLL.Services.Interfaces;
using HealthcareApp.BLL.DTOs;

namespace HealthcareApp.MVC.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _service;

        public DoctorController(IDoctorService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var doctors = _service.GetAll();
            return View(doctors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DoctorDto dto)
        {
            if (ModelState.IsValid)
            {
                _service.Add(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var doctor = _service.GetById(id);
            if (doctor == null) return NotFound();

            return View(doctor);
        }

        [HttpPost]
        public IActionResult Edit(DoctorDto dto)
        {
            if (ModelState.IsValid)
            {
                _service.Update(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        public IActionResult Delete(int id)
        {
            var doctor = _service.GetById(id);
            if (doctor == null) return NotFound();

            return View(doctor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}