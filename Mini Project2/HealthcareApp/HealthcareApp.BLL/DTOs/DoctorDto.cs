using System.ComponentModel.DataAnnotations;

namespace HealthcareApp.BLL.DTOs
{
    public class DoctorDto
    {
        public int DoctorId { get; set; }

        public string? Name { get; set; }

        public string? Specialization { get; set; }

        public string? AvailableTimeSlot { get; set; }
    }
}