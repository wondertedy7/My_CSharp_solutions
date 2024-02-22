using System;
using System.Diagnostics.Tracing;

namespace P04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentation;
            double marksCount = juryCount;
            double average = 0;
            int presentationCount = 0;

            while ((presentation = Console.ReadLine()) != "Finish")
            {
                presentationCount++;
                double all = 0;

                for (int i = 1; i <= marksCount; i++)
                {
                    double marks = double.Parse(Console.ReadLine());
                    all += marks;
                    average += marks;
                }
                Console.WriteLine($"{presentation} - {all / marksCount:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {average / (marksCount * presentationCount):f2}.");
        }
    }
}
