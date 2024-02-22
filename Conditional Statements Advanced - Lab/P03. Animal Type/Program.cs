﻿using System;

namespace P03._Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string animal = Console.ReadLine();

            // logic

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
