using System;
using System.Security.Cryptography.X509Certificates;

namespace P04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishermen = int.Parse(Console.ReadLine());

            // logic

            double rentPrice = 0;
            double discount = 0;


            if (season == "Spring")
            {
                if (countFishermen <= 6)
                {
                    discount = 3000 * 0.1;
                }
                else if (countFishermen >= 7 && countFishermen <= 11)
                {
                    discount = 3000 * 0.15;
                }
                else if (countFishermen > 12)
                {
                    discount = 3000 * 0.25;
                }
                rentPrice = 3000 - discount;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (countFishermen <= 6)
                {
                    discount = 4200 * 0.1;
                }
                else if (countFishermen >= 7 && countFishermen <= 11)
                {
                    discount = 4200 * 0.15;
                }
                else if (countFishermen >=12)
                {
                    discount = 4200 * 0.25;
                }
                rentPrice = 4200 - discount;               
            }
            else if (season == "Winter")
            {
                if (countFishermen <= 6)
                {
                    discount = 2600 * 0.1;
                }
                else if (countFishermen >= 7 && countFishermen <= 11)
                {
                    discount = 2600 * 0.15;
                }
                else if (countFishermen > 12)
                {
                    discount = 2600 * 0.25;
                }
                rentPrice = 2600 - discount;
            }
            if (countFishermen % 2 == 0 && season != "Autumn")
            {
                rentPrice -= rentPrice * 0.05;
            }

            // output

            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {(budget - rentPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(rentPrice - budget):f2} leva.");
            }


        }
    }
}
