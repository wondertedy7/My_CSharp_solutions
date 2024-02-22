using System;

namespace P07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string month = Console.ReadLine();
            double countNights = double.Parse(Console.ReadLine());

            // logic

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (countNights > 7 && countNights <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (countNights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
   
                if (countNights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
                
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;

                if (countNights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            
            // output

            Console.WriteLine($"Apartment: {apartmentPrice * countNights:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice * countNights:f2} lv.");
        }
    }
}
