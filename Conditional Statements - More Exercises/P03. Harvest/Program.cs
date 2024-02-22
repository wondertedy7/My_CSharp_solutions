using System;

namespace P03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input

            int vineyard = int.Parse(Console.ReadLine());
            double grapesHarvestPerM2 = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            // logic
            double harvest = vineyard * grapesHarvestPerM2;
            double wineProdused = (harvest * 0.4) / 2.5;

            // output

            if (wineProdused < wineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {(Math.Floor(wineNeeded - wineProdused))} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProdused)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineProdused - wineNeeded)} liters left -> {Math.Ceiling((wineProdused - wineNeeded) / workers)} liters per person.");
            }

        }
    }
}
