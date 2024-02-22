using System;

namespace P08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string seriesName = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());

            // logic

            double timeForLunch = breakDuration / 8;
            double relaxTime = breakDuration / 4;
            double timeLeft = breakDuration - (timeForLunch + relaxTime);

            // output

            if (timeLeft >= seriesDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - seriesDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesDuration - timeLeft)} more minutes.");
            }
        }
    }
}

