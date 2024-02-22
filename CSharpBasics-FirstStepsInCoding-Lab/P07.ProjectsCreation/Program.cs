using System;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countProject = int.Parse(Console.ReadLine());
            int timeNeeded = 3;
            int hours = countProject * timeNeeded;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {countProject} project/s.");



        }
    }
}
