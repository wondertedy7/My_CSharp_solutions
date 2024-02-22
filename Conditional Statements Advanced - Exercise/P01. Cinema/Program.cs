using System;

namespace P01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string typeProjection = Console.ReadLine();
            int countRaws = int.Parse(Console.ReadLine()); 
            int countColums = int.Parse(Console.ReadLine());

            // logic

            double income = 0;
            if (typeProjection == "Premiere")
            {
                income = countRaws * countColums * 12.00;
            }
            else if (typeProjection == "Normal")
            {
                income = countRaws * countColums * 7.50;
            }
            else if (typeProjection == "Discount")
            {
                income = countRaws * countColums * 5.00;
            }

            // output

            Console.WriteLine($"{income:f2}");



        }
    }
}
