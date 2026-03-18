using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class StringLength
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the name: ");
            String s = Console.ReadLine();
            for (int i = 0; i<s.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
