using System;

namespace P04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input

            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            // logic
            
            double taxiPerKmDay = 0.79;
            double taxiPerKmNight = 0.90;
            double taxiStartPrice = 0.70;

            if (distance >= 100)
            {
                Console.WriteLine($"{distance * 0.06:f2}");
            }
            else if (distance >= 20)
            {
                Console.WriteLine($"{distance * 0.09:f2}");
            }
            else if (distance < 20 && dayOrNight == "day")
            {
                Console.WriteLine($"{taxiStartPrice + distance * taxiPerKmDay:f2}");
            }
            else
            {
                Console.WriteLine($"{taxiStartPrice + distance * taxiPerKmNight:f2}");
            }    
        }
    }
}
