using System;

namespace P01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyReceived = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            
            int yearsOld = 18;
            double moneyRemain = 0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyReceived -= 12000;
                }
                else
                {
                    moneyReceived -= 12000 + (50 * (double)yearsOld);
                }
                yearsOld++;
            }
            moneyRemain = moneyReceived;
            if (moneyReceived >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyReceived:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyReceived):f2} dollars to survive.");
            }
        }
    }
}
