using System.ComponentModel.DataAnnotations;

namespace HealthcareApp.BLL.DTOs
{
    public class PatientDto
    {
        public int PatientId { get; set; }

        [Required]
        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Gender { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? MedicalNotes { get; set; }
    }
}