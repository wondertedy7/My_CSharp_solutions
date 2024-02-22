using System;

namespace P02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input

            int holydays = int.Parse(Console.ReadLine());

            // logic
            int year = 365;
            int workdays = year - holydays;
            int workdaysPlay = workdays * 63;
            int holydaysPlay = holydays * 127;
            int tomPlayNormPerYear = 30000;
            int fullPlayTime = workdaysPlay + holydaysPlay;

            // output

            if (fullPlayTime > tomPlayNormPerYear)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(fullPlayTime - tomPlayNormPerYear) / 60} hours and {(fullPlayTime - tomPlayNormPerYear) % 60} minutes more for play");
            }
            else 
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(tomPlayNormPerYear - fullPlayTime) / 60} hours and {(tomPlayNormPerYear- fullPlayTime) % 60} minutes less for play");

            }    
            
        }
    }
}
