using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name: ");
            String s = Console.ReadLine();
            String rev = " ";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            if (rev == s)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }
}