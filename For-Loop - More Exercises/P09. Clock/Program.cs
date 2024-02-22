using System;

namespace P09._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 24; i++)
            {
                for (int i1 = 0; i1 < 60; i1++)
                {
                   Console.WriteLine($"{i} : {i1}");
                }
            }
        }
    }
}
