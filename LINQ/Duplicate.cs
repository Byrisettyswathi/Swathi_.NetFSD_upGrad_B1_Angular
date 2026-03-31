using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    internal class Duplicate
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            { 1, 2, 3, 2, 4, 5, 3, 6 };


            // 1. Remove duplicates
            var unique = numbers.Distinct();

            Console.WriteLine("Unique numbers");
            foreach (var n in unique)
            {
                Console.WriteLine(n);
            }


            // 2. Find duplicate values
            var duplicates = numbers.GroupBy(n => n)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            Console.WriteLine("\nDuplicate numbers");
            foreach (var n in duplicates)
            {
                Console.WriteLine(n);
            }


            // 3. Count occurrence of each number
            var countEach = numbers.GroupBy(n => n)
                .Select(g => new
                {
                    Number = g.Key,
                    Count = g.Count()
                });

            Console.WriteLine("\nCount of each number");

            foreach (var x in countEach)
            {
                Console.WriteLine(x.Number + " = " + x.Count);
            }
        }
    }
}