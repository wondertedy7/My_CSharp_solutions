﻿using System;

namespace P09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string product = Console.ReadLine();

            // logic

            if (product == "banana" || product == "apple" || product == "kiwi"
                || product == "cherry" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" 
                || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}