using System;

namespace P02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int meditians = 7;
            int treated = 0;
            int untreated = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if ( i % 3 == 0 && untreated > treated)
                {
                    meditians++;
                }
                if (patients <= meditians)
                {
                    treated += patients;
                }
                if (patients > meditians)
                {
                    untreated += patients - meditians;
                    treated += meditians;
                }

            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");

        }
    }
}
