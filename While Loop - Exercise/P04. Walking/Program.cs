using System;

namespace P04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string steps;
            int goal = 10000;
            int allSteps = 0;

            while (allSteps < goal)
            {
                steps = Console.ReadLine();
                if (steps != "Going home")
                {
                    int everySteps = int.Parse(steps);
                    allSteps += everySteps;
                }
                if (steps == "Going home")
                {
                    int homeSteps = int.Parse(Console.ReadLine());
                    allSteps += homeSteps;
                    break;
                }
            }
            if (allSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{allSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(goal - allSteps)} more steps to reach goal.");
            }
        }
    }
}
