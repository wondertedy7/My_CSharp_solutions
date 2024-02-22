using System;

namespace P06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int nRaters = int.Parse(Console.ReadLine());

            // logic

            double sum = 0;
           
            for (int i = 1; i <= nRaters; i++)
            {
                //int points = 0;
                double pointsSum = 0;

                string ratersName = Console.ReadLine();
                double raterPoints = double.Parse(Console.ReadLine());
                
                pointsSum = academyPoints + (ratersName.Length * raterPoints / 2);
                

                if (pointsSum > academyPoints)
                {
                    academyPoints = pointsSum;
                }
                sum = pointsSum;
                if (sum > 1250.5)
                {
                    break;
                }             
                
            }

            // output

            if (sum > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - sum:f1} more!");
            }


        }
    }
}
