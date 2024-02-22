using System;

namespace P06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());

            // logic

            double delay = Math.Floor(distance / 15) * 12.5;
            double ivanRecord = distance * secPerMeter + delay;

            // output

            if (ivanRecord < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivanRecord:f2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {ivanRecord - worldRecord:f2} seconds slower.");
            }
        }
    }
}
 