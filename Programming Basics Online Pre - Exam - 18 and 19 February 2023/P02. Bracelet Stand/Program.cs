using System;

namespace P02._Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dayMoney = double.Parse(Console.ReadLine());
            double dayearnings = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());
            double giftPrise = double.Parse(Console.ReadLine());

            int days = 5;

            double allDayMoney = dayMoney * days;
            double allDayEarnings = dayearnings * days;
            double totalMoney = (allDayMoney + allDayEarnings) - expenses;

            if (totalMoney >= giftPrise)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else 
            {
                Console.WriteLine($"Insufficient money: {(giftPrise - totalMoney):f2} BGN.");
            }

        }
    }
}
