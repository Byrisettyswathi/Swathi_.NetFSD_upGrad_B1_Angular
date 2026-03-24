using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    internal class String
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Ravi", "Kiran", "Amit", "Raj", "Anil"
            };

            // 1. Names starting with A
            var startWithA = names.Where(n => n.StartsWith("A"));

            Console.WriteLine("Names starting with A");
            foreach (var n in startWithA)
            {
                Console.WriteLine(n);
            }


            // 2. Sort alphabetically
            var sorted = names.OrderBy(n => n);

            Console.WriteLine("\nSorted names");
            foreach (var n in sorted)
            {
                Console.WriteLine(n);
            }


            // 3. Convert to uppercase
            var upper = names.Select(n => n.ToUpper());

            Console.WriteLine("\nUppercase names");
            foreach (var n in upper)
            {
                Console.WriteLine(n);
            }


            // 4. Length > 4
            var length4 = names.Where(n => n.Length > 4);

            Console.WriteLine("\nLength > 4");
            foreach (var n in length4)
            {
                Console.WriteLine(n);
            }
        }
    }
}