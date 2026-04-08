using HealthcareApp.BLL.DTOs;
using System.Collections.Generic;

namespace HealthcareApp.BLL.Services.Interfaces
{
    public interface IPatientService
    {
        IEnumerable<PatientDto> GetAll();
        PatientDto GetById(int id);
        void Add(PatientDto dto);
        void Update(PatientDto dto);
        void Delete(int id);
    }
}