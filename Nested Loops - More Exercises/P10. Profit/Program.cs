using System;

namespace P10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coins1Lev = int.Parse(Console.ReadLine());
            int coins2Leva = int.Parse(Console.ReadLine());
            int banknote5Leva = int.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i <= coins1Lev; i++)
            {
                for (int j = 0; j <= coins2Leva; j++)
                {
                    for (int k = 0; k <= banknote5Leva; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == amount)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {amount} lv.");
                        }
                    }
                }
            }
        }
    }
}
