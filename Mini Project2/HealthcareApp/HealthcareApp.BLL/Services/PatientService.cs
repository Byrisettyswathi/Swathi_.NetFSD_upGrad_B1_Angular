using HealthcareApp.BLL.DTOs;
using HealthcareApp.BLL.Services.Interfaces;
using HealthcareApp.DAL.Repositories.Interfaces;
using HealthcareApp.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareApp.BLL.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repo;

        public PatientService(IPatientRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<PatientDto> GetAll()
        {
            return _repo.GetAll().Select(p => new PatientDto
            {
                PatientId = p.PatientId,
                Name = p.Name,
                Age = p.Age,
                Gender = p.Gender,
                PhoneNumber = p.PhoneNumber,
                Email = p.Email,
                MedicalNotes = p.MedicalNotes
            });
        }

        public PatientDto? GetById(int id)
        {
            var p = _repo.GetById(id);
            if (p == null) return null;

            return new PatientDto
            {
                PatientId = p.PatientId,
                Name = p.Name,
                Age = p.Age,
                Gender = p.Gender,
                PhoneNumber = p.PhoneNumber,
                Email = p.Email,
                MedicalNotes = p.MedicalNotes
            };
        }

        public void Add(PatientDto dto)
        {
            var patient = new Patient
            {
                Name = dto.Name,
                Age = dto.Age,
                Gender = dto.Gender,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                MedicalNotes = dto.MedicalNotes
            };

            _repo.Add(patient);
        }

        public void Update(PatientDto dto)
        {
            var patient = new Patient
            {
                PatientId = dto.PatientId,
                Name = dto.Name,
                Age = dto.Age,
                Gender = dto.Gender,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                MedicalNotes = dto.MedicalNotes
            };

            _repo.Update(patient);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}