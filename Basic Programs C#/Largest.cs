using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Largest
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter the Start numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End numbers: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Start numbers: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2  && num1 > num2)
            {
                Console.WriteLine("Largest Number is : " + num1);
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Largest Number is : " + num2);
            }
            if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine("Largest Number is : " + num3);
            }
        }
    }
}