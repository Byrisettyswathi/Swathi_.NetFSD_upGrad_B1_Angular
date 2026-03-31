using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Hospital
    {
        public static string? Hospital_Name;
        public static string? Hospital_Address;
        public string? Patient_Name;
    }

    internal class Hospital1
    {
        static void Main()
        {
            Hospital.Hospital_Name = "KIMS Hospital";
            Hospital.Hospital_Address = "Nellore";

            Hospital p1 = new Hospital();
            Hospital p2 = new Hospital();
            Hospital p3 = new Hospital();

            p1.Patient_Name = "Reethu";
            p2.Patient_Name = "Manu";
            p3.Patient_Name = "Sunnu";

            Console.WriteLine(Hospital.Hospital_Name + " " + Hospital.Hospital_Address + " " + p1.Patient_Name);
            Console.WriteLine(Hospital.Hospital_Name + " " + Hospital.Hospital_Address + " " + p2.Patient_Name);
            Console.WriteLine(Hospital.Hospital_Name + " " + Hospital.Hospital_Address + " " + p3.Patient_Name);
        }
    }
}