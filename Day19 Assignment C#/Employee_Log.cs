using System;
using System.IO;

class Employee_Log
{
    static string filePath = "employee_log.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Login");
            Console.WriteLine("2. Logout Update");
            Console.WriteLine("3. Exit");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
                AddLogin();

            else if (ch == 2)
                UpdateLogout();

            else
                break;
        }
    }

    static void AddLogin()
    {
        try
        {
            Console.Write("Enter Id: ");
            string id = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            string loginTime = DateTime.Now.ToString();

            string line =
                         id + " | " +
                         name + " | " +
                         loginTime + " | NotLoggedOut";

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(line);
            }

            Console.WriteLine("Login saved");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void UpdateLogout()
    {
        try
        {
            Console.Write("Enter Id: ");
            string id = Console.ReadLine();

            string[] lines =
                File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(id + " |"))
                {
                    string logout =
                        DateTime.Now.ToString();

                    string[] parts =
                        lines[i].Split('|');

                    lines[i] =
                        parts[0] + "|" +
                        parts[1] + "|" +
                        parts[2] + "|" +
                        logout;
                }
            }

            File.WriteAllLines(filePath, lines);

            Console.WriteLine("Logout updated");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}