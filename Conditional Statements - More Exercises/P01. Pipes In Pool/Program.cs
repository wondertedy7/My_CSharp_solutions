using System;

namespace P01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input

            int poolMaxVolume = int.Parse(Console.ReadLine());
            int p1Debit = int.Parse(Console.ReadLine());
            int p2Debit = int.Parse(Console.ReadLine());
            double hoursGone = double.Parse(Console.ReadLine());

            // logic

            double fullDebit = p1Debit + p2Debit;
            double poolVolume = fullDebit * hoursGone;
            double percentP1Volume = (p1Debit * 100) / fullDebit;
            double percentP2Volume = (p2Debit * 100) / fullDebit;
            double percentPullVolume = (poolVolume * 100) / poolMaxVolume;

            // output

            if (poolVolume <= poolMaxVolume)
            {
                Console.WriteLine($"The pool is {percentPullVolume:f2}% full. Pipe 1: {percentP1Volume:f2}%. Pipe 2: {percentP2Volume:f2}%.");
            }
            else 
            {
                Console.WriteLine($"For {hoursGone:f2} hours the pool overflows with {Math.Abs(poolMaxVolume - poolVolume):f2} liters.");
            }
        }
    }
}
