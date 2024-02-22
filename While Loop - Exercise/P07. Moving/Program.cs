using System;

namespace P07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double freeSpace = width * length * height;
            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                int boxes = int.Parse(command);
                freeSpace -= boxes;

                if (freeSpace <= 0) 
                {
                    break;
                }
            }
            if (freeSpace <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
