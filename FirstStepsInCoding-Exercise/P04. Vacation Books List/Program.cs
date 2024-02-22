using System;

namespace P04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int pgsCount = int.Parse(Console.ReadLine());
            int pgsPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // logic

            int readingTime = pgsCount / pgsPerHour;
            int hoursPerDay = readingTime / days;

            // output

            Console.WriteLine(hoursPerDay);
        }
    }
}
