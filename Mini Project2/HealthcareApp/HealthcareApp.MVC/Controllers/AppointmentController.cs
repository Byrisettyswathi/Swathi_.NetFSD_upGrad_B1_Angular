using HealthcareApp.BLL.DTOs;
using HealthcareApp.BLL.Services;
using HealthcareApp.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthcareApp.MVC.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _service;

        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var appointments = _service.GetAll();
            return View(appointments);
        }

        public IActionResult Create()
        {
            ViewBag.Patients = new SelectList(_patientService.GetAllPatients(), "PatientId", "Name");
            ViewBag.Doctors = new SelectList(_doctorService.GetAllDoctors(), "DoctorId", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(AppointmentDto dto)
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
            var appointment = _appointmentService.GetById(id);

            ViewBag.Patients = new SelectList(_patientService.GetAllPatients(), "PatientId", "Name", appointment.PatientId);
            ViewBag.Doctors = new SelectList(_doctorService.GetAllDoctors(), "DoctorId", "Name", appointment.DoctorId);

            return View(appointment);
        }

        [HttpPost]
        public IActionResult Edit(AppointmentDto dto)
        {a
            if (ModelState.IsValid)
            {
                _service.Update(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }
    }
}