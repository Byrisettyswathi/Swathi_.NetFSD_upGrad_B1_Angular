using HealthcareApp.BLL.DTOs;
using HealthcareApp.BLL.Services.Interfaces;
using HealthcareApp.DAL.Repositories.Interfaces;
using HealthcareApp.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareApp.BLL.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repo;

        public AppointmentService(IAppointmentRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<AppointmentDto> GetAll()
        {
            return _repo.GetAll().Select(a => new AppointmentDto
            {
                AppointmentId = a.AppointmentId,
                PatientId = a.PatientId,
                DoctorId = a.DoctorId,
                Date = a.Date,
                TimeSlot = a.TimeSlot,
                Status = a.Status
            });
        }

        public AppointmentDto? GetById(int id)
        {
            var a = _repo.GetById(id);
            if (a == null) return null;

            return new AppointmentDto
            {
                AppointmentId = a.AppointmentId,
                PatientId = a.PatientId,
                DoctorId = a.DoctorId,
                Date = a.Date,
                TimeSlot = a.TimeSlot,
                Status = a.Status
            };
        }

        public void Add(AppointmentDto dto)
        {
            var appointment = new Appointment
            {
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                Date = dto.Date,
                TimeSlot = dto.TimeSlot,
                Status = dto.Status
            };

            _repo.Add(appointment);
        }

        public void Update(AppointmentDto dto)
        {
            var appointment = new Appointment
            {
                AppointmentId = dto.AppointmentId,
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                Date = dto.Date,
                TimeSlot = dto.TimeSlot,
                Status = dto.Status
            };

            _repo.Update(appointment);
        }
    }
}