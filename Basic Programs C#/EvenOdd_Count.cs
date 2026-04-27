using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class EvenOdd_Count
    {
        static void Main(string[] args)
        {
            int Even = 0, Odd = 0;
            Console.WriteLine("Enter the Start numbers: ");
            int Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End numbers");
            int End = Convert.ToInt32(Console.ReadLine());
            for (int i = Start; i <= End; i++) {
                if (i % 2 == 0)
                {
                    Even++;
    
            }
                else
                {
                    Odd++;
                }

            }
            Console.WriteLine("Even numbers count: " + Even);
            Console.WriteLine("Odd numbers count: " + Odd);
        }
    } }
