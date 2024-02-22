using System;

namespace P01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            // logic

            int time = firstTime + secondTime + thirdTime;
            int min = time / 60;
            int sec = time % 60;

            // output

            if (sec < 10)
                Console.WriteLine($"{min}:0{sec}");
            else
                Console.WriteLine($" {min}:{sec}");

          
        }
    }
}
