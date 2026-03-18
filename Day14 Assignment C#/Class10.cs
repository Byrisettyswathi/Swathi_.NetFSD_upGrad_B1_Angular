using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Start numbers: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End numbers: ");
            int End = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= End; i++) {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
               
        }
            Console.ReadLine();
        }
    }
}
