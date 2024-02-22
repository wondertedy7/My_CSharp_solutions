using System;

namespace P09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int stayDays = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            // logic

            double pricePerNight = 0;
            double finalPrice = 0;
            int stayNights = stayDays - 1;

            if (kindOfRoom == "room for one person")
            {
                pricePerNight = 18.00;
                finalPrice = pricePerNight * stayNights;
            }
            else if (kindOfRoom == "apartment")
            {
                pricePerNight = 25;

                if (stayDays < 10)
                {
                    finalPrice = pricePerNight * stayNights * 0.7;
                }
                else if (stayDays >= 10 && stayDays <= 15)
                {
                    finalPrice = pricePerNight * stayNights * 0.65;
                }
                else if (stayDays > 15)
                {
                    finalPrice = pricePerNight * stayNights * 0.5;
                }
            }
            else if (kindOfRoom == "president apartment")
            {
                pricePerNight = 35;

                if (stayDays < 10)
                {
                    finalPrice = pricePerNight * stayNights * 0.9;
                }
                else if (stayDays >= 10 && stayDays <= 15)
                {
                    finalPrice = pricePerNight * stayNights * 0.85;
                }
                else if (stayDays > 15)
                {
                    finalPrice = pricePerNight * stayNights * 0.80;
                }
            }

            // output

            if (rating == "positive")
            {
                Console.WriteLine($"{finalPrice += finalPrice * 0.25:f2}");
            }
            else if (rating == "negative")
            {
                Console.WriteLine($"{finalPrice -= finalPrice * 0.1:f2}");
            }

            
        }
    }
}
