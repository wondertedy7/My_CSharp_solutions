using System;

namespace P10._Clock___part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 24; i++)
            {
                for (int i1 = 0; i1 < 60; i1++)
                {
                    for (int i2 = 0; i2 < 60; i2++)
                    {
                        Console.WriteLine($"{i} : {i1} : {i2}");
                    }
                }
            }
        }
    }
}
