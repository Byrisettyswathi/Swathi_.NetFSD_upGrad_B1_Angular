using HealthcareApp.BLL.DTOs;
using HealthcareApp.BLL.Services.Interfaces;
using HealthcareApp.DAL.Repositories.Interfaces;
using HealthcareApp.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareApp.BLL.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repo;


        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<DoctorDto> GetAll()
        {
            return _repo.GetAll().Select(d => new DoctorDto
            {
                DoctorId = d.DoctorId,
                Name = d.Name,
                Specialization = d.Specialization,
                AvailableTimeSlot = d.AvailableTimeSlot
            });
        }

        public DoctorDto GetById(int id)
        {
            var d = _repo.GetById(id);
            if (d == null) return null;

            return new DoctorDto
            {
                DoctorId = d.DoctorId,
                Name = d.Name,
                Specialization = d.Specialization,
                AvailableTimeSlot = d.AvailableTimeSlot
            };
        }

        public void Add(DoctorDto dto)
        {
            var doctor = new Doctor
            {
                Name = dto.Name,
                Specialization = dto.Specialization,
                AvailableTimeSlot = dto.AvailableTimeSlot
            };

            _repo.Add(doctor);
        }

        public void Update(DoctorDto dto)
        {
            var doctor = new Doctor
            {
                DoctorId = dto.DoctorId,
                Name = dto.Name,
                Specialization = dto.Specialization,
                AvailableTimeSlot = dto.AvailableTimeSlot
            };

            _repo.Update(doctor);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}