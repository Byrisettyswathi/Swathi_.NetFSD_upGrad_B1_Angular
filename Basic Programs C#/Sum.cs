using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Sum = num1 + num2;
            Console.WriteLine("Sum of 2 numbers" ,+Sum);

        }
    }
}
