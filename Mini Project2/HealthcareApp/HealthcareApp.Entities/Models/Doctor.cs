using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthcareApp.Entities.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }


        [Required]
        [StringLength(30)]
        public string? Name { get; set; }


        [Required]
        public string? Specialization { get; set; }


        [Required]
        public string? AvailableTimeSlot { get; set; }

        // NAVIGATION PROPERTY
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}