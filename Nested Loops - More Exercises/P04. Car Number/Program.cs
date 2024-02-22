using System;

namespace P04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = beginning; i <= end; i++)
            {
                for (int j = beginning; j <= end; j++)
                {
                    for (int k = beginning; k <= end; k++)
                    {
                        for (int l = beginning; l <= end; l++)
                        {
                            if (i % 2 == 0 && l % 2 != 0 && i > l && (j + k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                            else if (i % 2 != 0 && l % 2 == 0 && i > l && (j + k)% 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
