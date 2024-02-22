using System;

namespace P05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string destination;
            double budget;

            while ((input = Console.ReadLine()) != "End")
            {
                destination = input;
                budget = double.Parse(Console.ReadLine());

                while (budget > 0)
                {
                    double saved = double.Parse(Console.ReadLine());
                    budget -= saved;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
