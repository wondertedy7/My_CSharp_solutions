using System;
using System.Reflection.Metadata;

namespace P04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            // logic

            double puzzlesSum = puzzles * 2.60;
            double dollsSum = dolls * 3;
            double bearsSum = bears * 4.10;
            double minionsSum = minions * 8.20;
            double trucksSum = trucks * 2;

            int allToys = puzzles + dolls + bears + minions + trucks;

            double toysPrice = puzzlesSum+dollsSum+bearsSum+minionsSum+trucksSum;
            // тук може да се запише и така: 
            // double toysPrice = puzzles * 2,60 + dolls * 3 + bears * 4,10 + minions * 8,20 + trucks * 2;
            // така спестяваме горните 5 променливи за цените на всяка играчка поотделно!

            if (allToys >= 50)
            {
                toysPrice -= toysPrice * 0.25;
            }

            double rent = toysPrice * 0.1;

            double earnings = toysPrice - rent;

            // output

            if (earnings >= tripPrice )
            {
                Console.WriteLine($"Yes! {earnings - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - earnings:f2} lv needed.");

            }
        }
    }
}
