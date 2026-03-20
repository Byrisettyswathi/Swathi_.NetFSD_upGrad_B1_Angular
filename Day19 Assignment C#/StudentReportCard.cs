using System;
using System.IO;

class StudentReportCard
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Report Card Generator ---");
            Console.WriteLine("1. Create Report");
            Console.WriteLine("2. Read Report");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CreateReport();
            }
            else if (choice == 2)
            {
                ReadReport();
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }

    static void CreateReport()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();

            Console.Write("Enter Marks Subject 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks Subject 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks Subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

         
            int total = m1 + m2 + m3;
            double avg = total / 3.0;

            string grade;

            if (avg >= 80)
                grade = "A";
            else if (avg >= 60)
                grade = "B";
            else if (avg >= 40)
                grade = "C";
            else
                grade = "Fail";

            string content =
                "Student Name: " + name + "\n" +
                "Roll Number: " + roll + "\n" +
                "Marks: " + m1 + ", " + m2 + ", " + m3 + "\n" +
                "Total: " + total + "\n" +
                "Average: " + avg + "\n" +
                "Grade: " + grade;

            string fileName = roll + ".txt";

            File.WriteAllText(fileName, content);

            Console.WriteLine("Report saved as " + fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ReadReport()
    {
        try
        {
            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();

            string fileName = roll + ".txt";

            if (File.Exists(fileName))
            {
                string data = File.ReadAllText(fileName);
                Console.WriteLine("\n--- Report ---");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Report not found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}