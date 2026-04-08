using HealthcareApp.DAL.Database;
using HealthcareApp.DAL.Repositories.Interfaces;
using HealthcareApp.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareApp.DAL.Repositories.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _context;

        public DoctorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }

        public Doctor? GetById(int id)
        {
            return _context.Doctors.Find(id);
        }

        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void Update(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.Doctors.Find(id);
            if (data != null)
            {
                _context.Doctors.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}