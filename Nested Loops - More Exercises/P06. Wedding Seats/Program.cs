using System;
using System.Runtime.InteropServices;

namespace P06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());

            char firstSector = (char)65;
            int firstSeat = 97;
            int seat = 0;
            int counter = 0;
           

            for (char i = firstSector; i <= lastSector; i++)
            {

                for (int j = 1; j <= rowsCount; j++)
                {

                    if (j % 2 != 0)
                    {
                        for (int n = firstSeat; n < (firstSeat + oddRowSeats); n++)
                        {
                            Console.WriteLine($"{i}{j}{(char)n}");
                            counter++;
                        }
                    }
                    else if (j % 2 == 0)
                    {
                        seat = oddRowSeats + 2;
                        for (int k = firstSeat; k < (firstSeat + seat); k++)
                        {
                            Console.WriteLine($"{i}{j}{(char)k}");
                            counter++;
                        }
                    }
                }
                rowsCount++;
            }
            Console.WriteLine(counter);

        }
    }
}
