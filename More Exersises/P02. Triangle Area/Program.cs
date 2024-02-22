using System;

namespace P02._Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // logic

            double area = a * h / 2;

            // output

            Console.WriteLine("{0:f2}", area);
        }
    }
}
