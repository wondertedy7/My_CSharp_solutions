﻿using System;

namespace P05._Number_100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int num = int.Parse(Console.ReadLine());

            // output

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }

        }
    }
}
