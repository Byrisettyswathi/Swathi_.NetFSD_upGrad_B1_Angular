using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Fibanocci
    {
        static void Main(string[] args)
        {
            int limit, a = 0, b = 1, c;
            Console.WriteLine("Enter the limit: ");
            limit = Convert.ToInt32(Console.ReadLine());
            while (a <= limit) {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.Read();  
        }
    }
}
