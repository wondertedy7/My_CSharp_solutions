using System;

namespace P11._HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int hoursCount = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                double evenHour = 0;
                double oddHour = 0;
                double otherHour = 0;

                for (int j = 1; j <= hoursCount; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        oddHour += 2.50;
                    }
                    else if (i % 2 !=0 && j % 2 == 0)
                    {
                        evenHour += 1.25;
                    }
                    else
                    {
                        otherHour += 1;
                    }
                }
                double sumOddDay = evenHour + otherHour;
                double sumEvenDay = oddHour + otherHour;

                if (i % 2 == 0)
                {
                    Console.WriteLine($"Day: {i} - {sumEvenDay:f2} leva");
                    totalSum += sumEvenDay;
                }
                else
                {
                    Console.WriteLine($"Day: {i} - {sumOddDay:f2} leva");
                    totalSum += sumOddDay;
                }
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
