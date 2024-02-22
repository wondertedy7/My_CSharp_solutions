using System;
using System.Globalization;

namespace P09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isMagic = false;
            int i = 0;
            int j = 0;

            for (i = beginning; i <= end; i++)
            {
                for (j = beginning; j <= end; j++)
                {
                    counter++;

                    if (i + j == magicNum)
                    {
                        isMagic = true;
                        break;
                    }

                }
                if (isMagic)
                {
                    break;
                }

            }
            if (isMagic)
            {
                Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
            }
            else
            { 
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
