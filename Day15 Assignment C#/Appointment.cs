using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Appointment
    {
        public int AppointmentId;
        public string? PatientName;
        public string? DoctorName;
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }

    }
    internal class Appointment1
    {
        static void Main(string[] args)
        {
            Appointment a = new Appointment();
            a.AppointmentId = 1;
            a.PatientName = "Mini";

            Console.WriteLine(a.AppointmentId);
            Console.WriteLine(a.PatientName);
            Console.WriteLine(a.DoctorName);
            Console.WriteLine(a.AppointmentDate);

        }
    }

}
