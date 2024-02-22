using System;

namespace P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            // logic

            double videocardsPrice = videocards * 250;
            double totalSum = videocardsPrice + cpu * (videocardsPrice * 0.35) + ram * (videocardsPrice * 0.1);

            if (videocards > cpu)
            {
                totalSum -= totalSum * 0.15;
            }
            // output

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}
