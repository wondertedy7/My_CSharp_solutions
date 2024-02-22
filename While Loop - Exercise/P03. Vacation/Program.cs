using System;

namespace P03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            double spendingDays = 0;
            int daysPassed = 0;

            while (availableMoney < tripMoney && spendingDays < 5)
            {
                string actions = Console.ReadLine();
                double dayMoney = double.Parse(Console.ReadLine());
                daysPassed++;

                if (actions == "spend")
                {
                    availableMoney -= dayMoney;
                    spendingDays++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (actions == "save")
                {
                    availableMoney += dayMoney;
                    spendingDays = 0;
                }
            }
            if (spendingDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysPassed}");
            }
            if (availableMoney >= tripMoney)
            {
                Console.WriteLine($"You saved the money for {daysPassed} days.");
            }
        }
    }
}
