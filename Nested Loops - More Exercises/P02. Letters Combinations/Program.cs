using System;

namespace P02._Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char beginning = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = beginning; i <= end; i++)
            {
                for (char j = beginning; j <= end; j++)
                {
                    for (char k = beginning; k <= end; k++)
                    {
                        if (i != exeption && j != exeption && k != exeption)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write($"{counter}");
        }
    }
}
