using System;

namespace P01._Trapeziod_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());   
            double h = double.Parse(Console.ReadLine());

            //logic

            double trapeziodArea = (b1 + b2) * h / 2;
            
            // output

            Console.WriteLine("{0:f2}", trapeziodArea);
        }
    }
}
