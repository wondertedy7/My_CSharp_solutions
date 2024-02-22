using System;

namespace P08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            // logic

            examMinutes = examMinutes + examHour * 60;
            arrivalMinutes = arrivalMinutes + arrivalHour * 60;

            int difference = examMinutes - arrivalMinutes;

           if (difference < 0)
            {
                Console.WriteLine("Late");

                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):d2} hours after the start");
                }
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");

                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
           else
            {
                Console.WriteLine("Early");

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours before the start");
                }
            }

            
        }
    }
}
