﻿using System;

namespace P02._Numbers_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1 ; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
