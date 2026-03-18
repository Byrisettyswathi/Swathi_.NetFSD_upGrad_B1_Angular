using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0){
                Console.WriteLine("It is Even");

            }
            else{
                Console.WriteLine("Odd Number");
            }

        }
    }
}
