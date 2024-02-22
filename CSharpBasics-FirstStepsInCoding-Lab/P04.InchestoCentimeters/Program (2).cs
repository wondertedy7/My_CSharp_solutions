using System;

namespace P04.InchestoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sm = a * 2.54;

            Console.WriteLine(sm);
        }
    }
}
