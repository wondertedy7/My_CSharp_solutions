using System;

namespace P02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            int num;

            // logic
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());  
                
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }

            }
            sum -= maxNum;
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
