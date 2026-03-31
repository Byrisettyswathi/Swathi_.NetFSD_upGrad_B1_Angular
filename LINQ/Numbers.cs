using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    internal class Numbers
    {
        static void Main()
        {


            List<int> numbers = new List<int>() { 5, 10, 15, 20, 25, 30 };

            var result4 = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("\n Getting even Numbers:");
            foreach (var n in result4)
            {
                Console.WriteLine(n);

            }
                var result5 = numbers.Where(n => n > 15);
                Console.WriteLine("\n Greater than 15:");
                foreach (var n in result5)
                {
                    Console.WriteLine(n);

                }
            var result6 = numbers.Select(n => n * n);
            Console.WriteLine("\n square of each number:");
            foreach (var n in result6)
            {
                Console.WriteLine(n);

            }

            var result7 = numbers.Count(n => n % 5 ==0);
            Console.WriteLine("\n count divisible by 5:");
                Console.WriteLine(result7);

            

        }
    }
}