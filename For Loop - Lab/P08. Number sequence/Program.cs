using System;

namespace P08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int num = 0;
            for (int i = 1; i <= n ; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > maxNum)
                {
                    maxNum = num;
                }
                if (num < minNum) 
                {
                    minNum = num;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");

        }
    }
}
