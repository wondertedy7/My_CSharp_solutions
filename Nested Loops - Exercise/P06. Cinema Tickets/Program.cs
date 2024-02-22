using System;

namespace P06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName;
            int seats;
            int student = 0;
            int standard = 0;
            int kid = 0;
            int totalTicket = 0;

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                seats = int.Parse(Console.ReadLine());

                int ticketCounter = 0;
                for (int i = 1; i <= seats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    ticketCounter++;

                    if (ticketType == "student")
                    {
                        student++;
                    }
                    if (ticketType == "standard")
                    {
                        standard++;
                    }
                    if (ticketType == "kid")
                    {
                        kid++;
                    }

                }
                totalTicket += ticketCounter;

                Console.WriteLine($"{movieName} - {(double)ticketCounter * 100 / seats:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{(double)student * 100 / totalTicket:f2}% student tickets.");
            Console.WriteLine($"{(double)standard * 100 / totalTicket:f2}% standard tickets.");
            Console.WriteLine($"{(double)kid * 100 / totalTicket:f2}% kids tickets.");  
        }
    }
}
