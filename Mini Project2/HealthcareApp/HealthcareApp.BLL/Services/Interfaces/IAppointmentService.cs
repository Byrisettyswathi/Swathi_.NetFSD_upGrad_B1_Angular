using HealthcareApp.BLL.DTOs;
using System.Collections.Generic;

namespace HealthcareApp.BLL.Services.Interfaces
{
    public interface IAppointmentService
    {
        IEnumerable<AppointmentDto> GetAll();
        AppointmentDto GetById(int id);
        void Add(AppointmentDto dto);
        void Update(AppointmentDto dto);
    }
}