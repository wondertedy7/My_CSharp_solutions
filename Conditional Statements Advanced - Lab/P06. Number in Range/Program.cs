using System;

namespace P06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double number = double.Parse(Console.ReadLine());

            // logic

            if (number >= -100 && number != 0 && number <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
