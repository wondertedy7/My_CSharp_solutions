using System;

namespace P04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            // logic
            int money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }

            }
            // output

            if (money >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {money - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(money -washingMachinePrice):f2}");
            }
        }
    }
}
