using System;

namespace P02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int num = firstNum; num <= secondNum; num++)
            {
                int sumOdd = 0;
                int sumEven = 0;
                string currentNum = num.ToString();

                for (int i = 0; i < 6; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += currentNum[i];
                    }
                    else
                    {
                        sumOdd += currentNum[i];
                    }
                }
                if (sumOdd == sumEven)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
