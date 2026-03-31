using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment7
{
    internal class Intermediate_LINQ
    {
        public record Employee(int Id, string Name, string Department, int Salary);

    public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1,"Ravi","IT",50000),
                new Employee(2,"Anil","HR",40000),
                new Employee(3,"Kiran","IT",60000),
                new Employee(4,"Priya","Sales",45000),
                new Employee(5,"Neha","HR",55000),
                new Employee(6,"Amit","IT",70000)
            };

            var result1 = employees.Where(e=> e.Department == "IT");
            Console.WriteLine("\nGetting employess in IT Department");
            foreach (var e in result1)
            {
                Console.WriteLine(e.Name + " " + e.Department);
            }


            var high = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine("\nGet highest salary employee");
            Console.WriteLine(high.Name + " " + high.Salary);



            var average = employees.Average(e => e.Salary);
            Console.WriteLine("\nAverage salary of employees");
            Console.WriteLine(average);

            var result7 = employees.GroupBy(e => e.Department);
            Console.WriteLine("\ncount employeess in each department");
            foreach (var g in result7)
            {
                Console.WriteLine(g.Key);
                foreach (var e in g)
                {
                    Console.WriteLine("  " + e.Name);
                }

                var countDept = employees.GroupBy(e => e.Department) 
                    .Select(g => new
             {
                 Dept = g.Key,
                 Count = g.Count()
             });

                Console.WriteLine("\nCount per department");
                foreach (var c in countDept)
                {
                    Console.WriteLine(c.Dept + " " + c.Count);
                }
            }
        }
    }
}