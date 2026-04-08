using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthcareApp.Entities.Enums;

namespace HealthcareApp.Entities.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        // FOREIGN KEY
        [Required]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        // FOREIGN KEY
        [Required]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Time slot is required")]
        public string? TimeSlot { get; set; }

        // ENUM STATUS
        public AppointmentStatus Status { get; set; }
    }
}