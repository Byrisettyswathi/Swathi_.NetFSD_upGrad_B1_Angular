using Microsoft.AspNetCore.Mvc;
using HealthcareApp.BLL.Services.Interfaces;
using HealthcareApp.BLL.DTOs;

namespace HealthcareApp.MVC.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _service;

        public PatientController(IPatientService service)
        {
            _service = service;
        }

        // GET: Patient
        public IActionResult Index()
        {
            var patients = _service.GetAll();
            return View(patients);
        }

        // Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public IActionResult Create(PatientDto dto)
        {
            if (ModelState.IsValid)
            {
                _service.Add(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        // GET: Edit
        public IActionResult Edit(int id)
        {
            var patient = _service.GetById(id);
            if (patient == null) return NotFound();

            return View(patient);
        }

        // POST: Edit
        [HttpPost]
        public IActionResult Edit(PatientDto dto)
        {
            if (ModelState.IsValid)
            {
                _service.Update(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        // GET: Delete
        public IActionResult Delete(int id)
        {
            var patient = _service.GetById(id);
            if (patient == null) return NotFound();

            return View(patient);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}