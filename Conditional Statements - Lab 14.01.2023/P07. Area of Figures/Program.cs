using System;

namespace P07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string figure = Console.ReadLine();
            double area = 0;

            // logic

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }

            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                double ha = double.Parse(Console.ReadLine());
                double a = double.Parse(Console.ReadLine());
                area = ha * a / 2;
            }

            // output

            Console.WriteLine($"{area:f3}");
        }
    }
}
