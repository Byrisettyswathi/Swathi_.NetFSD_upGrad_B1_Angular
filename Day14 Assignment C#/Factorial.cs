using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num,  fact = 1;
            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) {
                 fact = fact * i;

            }
            Console.WriteLine("Factorial number is: " + fact);
            Console.ReadLine();
        }
    }
}
