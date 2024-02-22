using System;

namespace P08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int countTourney = int.Parse(Console.ReadLine());
            int ranglistPoints = int.Parse(Console.ReadLine());

            // logic
           
            string position;
            int finalPoints = 0;
            int points = 0;
            int wins = 0;

           
           for (int i = 1; i <= countTourney; i++)
            {
                position = Console.ReadLine();

                if (position == "W")
                {
                    points = 2000;
                    wins += 1;
                }
                else if (position == "F")
                {
                    points = 1200;
                }
                else if (position == "SF")
                {
                    points = 720;
                }

                finalPoints += points;
            }

            // output

            Console.WriteLine($"Final points: {ranglistPoints + finalPoints}");
            Console.WriteLine($"Average points: {finalPoints/countTourney}");
            Console.WriteLine($"{(double)wins/countTourney*100:f2}%");


        }
    }
}
