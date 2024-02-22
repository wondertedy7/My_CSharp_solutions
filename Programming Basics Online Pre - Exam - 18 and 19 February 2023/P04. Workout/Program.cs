using System;

namespace P04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysRunning = int.Parse(Console.ReadLine());
            double kmRunnedFirstDay = double.Parse(Console.ReadLine());

            int goal = 1000;
            double totalkm = kmRunnedFirstDay;
            double allKm = kmRunnedFirstDay;


            for (int i = 2; i <= daysRunning + 1;i++)
            {

                int percent = int.Parse(Console.ReadLine());
                allKm += allKm * percent / 100;
                totalkm += allKm;


            }
            if (totalkm >= goal)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalkm - goal)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(goal - totalkm)} more kilometers");
            }


        }
    }
}
