using System;

namespace P01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;
            bool bigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (currentNum > n)
                    {
                        bigger = true;
                        break;
                    }
                    Console.Write($"{currentNum} ");
                    currentNum++;
                }
                if (bigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
