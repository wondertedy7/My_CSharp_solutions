using System;

namespace P05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // logic

            double tripPrice = 0;
            string destination = "";
            string typeHoliday = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    typeHoliday = "Camp";
                    tripPrice = budget * 0.3;
                }
                else if (season == "winter")
                {
                    typeHoliday = "Hotel";
                    tripPrice = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    typeHoliday = "Camp";
                    tripPrice = budget * 0.4;
                }
                else if (season == "winter")
                {
                    typeHoliday = "Hotel";
                    tripPrice = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeHoliday = "Hotel";
                tripPrice = budget * 0.9;
            }

            // output

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeHoliday} - {tripPrice:f2}");
        }
    }
}
