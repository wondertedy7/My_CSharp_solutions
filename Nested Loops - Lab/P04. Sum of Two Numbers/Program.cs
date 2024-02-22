using System;

namespace P04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool stop = false;
            for (int i = beginning; i <= end; i++)
            {
                for (int j = beginning; j <= end; j++)
                {
                    counter++;
                    int result = i + j;

                    if (result == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        stop = true;
                        break;
                    }
                }
                if (stop)
                {
                    break;
                }
            }
            if (!stop)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
