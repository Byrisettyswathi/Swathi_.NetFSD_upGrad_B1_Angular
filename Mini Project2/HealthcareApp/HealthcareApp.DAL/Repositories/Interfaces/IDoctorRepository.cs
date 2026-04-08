
using HealthcareApp.Entities.Models;
using System.Collections.Generic;

namespace HealthcareApp.DAL.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAll();
        Doctor? GetById(int id);
        void Add(Doctor doctor);
        void Update(Doctor doctor);
        void Delete(int id);
    }
}