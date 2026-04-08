using HealthcareApp.BLL.DTOs;
using System.Collections.Generic;

namespace HealthcareApp.BLL.Services.Interfaces
{
    public interface IDoctorService
    {
        IEnumerable<DoctorDto> GetAll();
        DoctorDto GetById(int id);
        void Add(DoctorDto dto);
        void Update(DoctorDto dto);
        void Delete(int id);
    }
}