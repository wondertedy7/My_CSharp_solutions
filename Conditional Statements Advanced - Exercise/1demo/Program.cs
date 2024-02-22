using System;

namespace _1demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numHrizantem = int.Parse(Console.ReadLine());
            int numRozes = int.Parse(Console.ReadLine());
            int numLale = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double priceFlowers1 = 0;
            double priceFlowers2 = 0;
            double priceFlowers3 = 0;
            double allPrice = 0;

            double allFlowars = numHrizantem + numLale + numRozes;
            if (season == "Spring")
            {
                priceFlowers1 = (double)numHrizantem * 2;
                priceFlowers2 = (double)numRozes * 4.10;
                priceFlowers3 = (double)numLale * 2.50;
                allPrice = priceFlowers1 + priceFlowers2 + priceFlowers3;
                if (holiday == "Y")
                {
                    allPrice = allPrice * 1.15;
                }
            }
            else if (season == "Summer")
            {
                priceFlowers1 = (double)numHrizantem * 2;
                priceFlowers2 = (double)numRozes * 4.10;
                priceFlowers3 = (double)numLale * 2.50;
                allPrice = priceFlowers1 + priceFlowers2 + priceFlowers3;
                if (holiday == "Y")
                {
                    allPrice = allPrice * 1.15;
                }

            }
            else if (season == "Аutumn")
            {
                priceFlowers1 = (double)numHrizantem * 3.75;
                priceFlowers2 = (double)numRozes * 4.50;
                priceFlowers3 = (double)numLale * 4.15;
                allPrice = priceFlowers1 + priceFlowers2 + priceFlowers3;
                if (holiday == "Y")
                {
                    allPrice = allPrice - allPrice * 1.15;
                }

            }
            else if (season == "Winter")
            {
                priceFlowers1 = (double)numHrizantem * 3.75;
                priceFlowers2 = (double)numRozes * 4.50;
                priceFlowers3 = (double)numLale * 4.15;
                allPrice = priceFlowers1 + priceFlowers2 + priceFlowers3;
                if (holiday == "Y")
                {
                    allPrice = allPrice - allPrice * 1.15;
                }
            }
            if (numLale >= 7 && season == "Spring")

            {
                allPrice = allPrice - allPrice * 0.05;
            }
            if (numRozes >= 10 && season == "Winter")
            {
                allPrice = allPrice - allPrice * 0.1;
            }
            if (allFlowars >= 20)
            {
                allPrice = allPrice - allPrice * 0.2;
            }

            Console.WriteLine($"{allPrice + 2:f2}");
        }
    }
}
    

