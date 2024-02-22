using System;

namespace P05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menCount = int.Parse(Console.ReadLine());
            int womenCount = int.Parse(Console.ReadLine());
            int tablesCount = int.Parse(Console.ReadLine());

            int tablesOcupied = 0;

            for (int j = 1; j <= menCount; j++)
            {
                for (int k = 1; k <= womenCount; k++)
                {
                    if (tablesOcupied >= tablesCount)
                    {
                        break;
                    }
                    Console.Write($"({j} <-> {k}) ");
                    tablesOcupied++;
                }
            }
        }
    }
}
