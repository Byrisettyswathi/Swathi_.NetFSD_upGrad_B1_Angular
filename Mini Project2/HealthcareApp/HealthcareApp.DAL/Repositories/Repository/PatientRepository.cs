using Dapper;
using HealthcareApp.DAL.Database;
using HealthcareApp.DAL.Repositories.Interfaces;
using HealthcareApp.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace HealthcareApp.DAL.Repositories.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _context;
        private readonly string _connectionString;

        public PatientRepository(AppDbContext context)
        {
            _context = context;
            _connectionString = context.Database.GetConnectionString()!;
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patients.ToList();
        }

        public Patient? GetById(int id)
        {
            return _context.Patients.Find(id);
        }

        public void Add(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void Update(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.Patients.Find(id);
            if (data != null)
            {
                _context.Patients.Remove(data);
                _context.SaveChanges();
            }
        }


        //  Dapper 
        public IEnumerable<Patient> Search(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Patients WHERE Name LIKE @Name";
                return connection.Query<Patient>(query, new { Name = "%" + name + "%" }).ToList();
            }
        }
    }
}