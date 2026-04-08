using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthcareApp.Entities.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(30)]
        public string Name { get; set; }


        [Required]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }


        [Required]
        public string? Gender { get; set; }


        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        public string? PhoneNumber { get; set; }


        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }


        [StringLength(500)]
        public string? MedicalNotes { get; set; }

        // NAVIGATION PROPERTY
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}