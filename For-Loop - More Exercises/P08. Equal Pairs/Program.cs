using System;

namespace P08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            int sum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 1; i <= pairsCount; i++)
            {
               int num1 = int.Parse(Console.ReadLine());
               int num2 = int.Parse(Console.ReadLine());

               int currentSum = num2 + num1;
                
                if (i == 1)
                {
                    sum = currentSum;
                }
                else
                {
                    diff = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
