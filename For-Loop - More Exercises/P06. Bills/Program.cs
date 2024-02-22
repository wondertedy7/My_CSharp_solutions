using System;

namespace P06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            int water = 20;
            int internet = 15;
            double others = 0;
            double totalElektricity = 0;

            for (int i = 1; i <= months; i++)
            {
                double elektricity = double.Parse(Console.ReadLine());

                totalElektricity += elektricity;
            }
            others += (totalElektricity + (water * months) + (internet * months)) + (totalElektricity + (water * months) + (internet * months)) * 0.2;

            Console.WriteLine($"Electricity: {totalElektricity:f2} lv");
            Console.WriteLine($"Water: {water * months:f2} lv");
            Console.WriteLine($"Internet: {internet * months:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {(totalElektricity + (water * months) + (internet * months) + others) / months:f2} lv");

        }
    }
}
