using System;

namespace P05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double filmBudget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double statistsWearPrice = double.Parse(Console.ReadLine());

            // logic

            double decor = filmBudget * 0.1;

            if (statists > 150)
            {
                statistsWearPrice -= statistsWearPrice * 0.1;
            }
            double fullStatistsWear = statists * statistsWearPrice;

            // output

            if (decor + fullStatistsWear > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {decor + fullStatistsWear - filmBudget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - (decor + fullStatistsWear):f2} leva left.");
            }

        }
    }
}
