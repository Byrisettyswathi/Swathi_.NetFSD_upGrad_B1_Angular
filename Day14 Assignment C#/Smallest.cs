using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Smallest
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = num[0];
            for (int i = 1; i < 5; i++)
            {
                if (num[i] < smallest)
                {
                    smallest = num[i];
                }
            }
            Console.WriteLine("Smallest number is:" + smallest);
        }
    }
}