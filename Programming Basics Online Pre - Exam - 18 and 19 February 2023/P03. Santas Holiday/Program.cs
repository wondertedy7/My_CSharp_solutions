using System;

namespace P03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stayDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double pricePerNight = 0;
            double finalPrice = 0;
            int stayNights = stayDays - 1;

            if (typeOfRoom == "room for one person")
            {
                pricePerNight = 18.00;
                finalPrice = pricePerNight * stayNights;
            }
            else if (typeOfRoom == "apartment")
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
            else if (typeOfRoom == "president apartment")
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
