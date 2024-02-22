﻿using System;

namespace P03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // logic

            minutes += hours * 60;
            minutes += 15;

            hours = minutes / 60;
            minutes = minutes % 60;

            if (hours==24)
            {
                hours = 0;
            }

            // output

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
