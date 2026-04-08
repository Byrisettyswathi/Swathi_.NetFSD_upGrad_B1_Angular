using HealthcareApp.DAL.Database;
using HealthcareApp.DAL.Repositories.Interfaces;
using HealthcareApp.Entities.Enums;
using HealthcareApp.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareApp.DAL.Repositories.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .ToList();
        }

        public void Add(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public Appointment GetById(int id)
        {
            return _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .FirstOrDefault(a => a.AppointmentId == id);
        }

        public void Update(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> Filter(string status)
        {
            var enumStatus = Enum.Parse<AppointmentStatus>(status);
            return _context.Appointments
                .Where(a => a.Status == enumStatus)
                .ToList();
        }
    }
}