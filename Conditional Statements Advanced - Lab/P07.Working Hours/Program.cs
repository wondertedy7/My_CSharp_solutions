using System;
using System.Linq.Expressions;

namespace P07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            // logic

            if ((hour >= 10 && hour <= 18)
                && (day == "Monday" || day == "Tuesday"
                || day == "Wednesday"
                || day == "Thursday" || day == "Friday"
                || day == "Saturday"))
            {
                Console.WriteLine("open");
                
                // ДРУГ ВАРИАНТ НА РЕШЕНИЕ:
                //switch (day)
                //{
                //    case "Monday":
                //    case "Tuesday":
                //    case "Wednesday":
                //    case "Thursday":
                //    case "Friday":
                //    case "Saturday":
                //        Console.WriteLine("open");
                //        break;
                //    default:
                //        Console.WriteLine("closed");
                //        break;
                //}

            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
