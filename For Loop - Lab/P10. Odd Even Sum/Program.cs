﻿using System;

namespace P10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

         if (evenSum == oddSum)
         {
             Console.WriteLine("Yes");
             Console.WriteLine($"Sum = {evenSum}");
         }
         else
         {
             Console.WriteLine("No");
             Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
         }

        }
    }
}
