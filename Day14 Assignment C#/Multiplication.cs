using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Start numbers: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End numbers");
            int End = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= End; i++) {
                Console.WriteLine("Table of: " + i);
                for (int j = 1; j <= 10; j++)
                    Console.WriteLine(i + "*" + j + "=" + (i*j));
                }
            Console.WriteLine();
            Console.WriteLine();

        }
       
    }
}
