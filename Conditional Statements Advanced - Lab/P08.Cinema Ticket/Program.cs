using System;

namespace P08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string day = Console.ReadLine();

            logic

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine(16);
            }


            // ANOTHER SOLUTION: 

            //switch (day)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Friday":
            //        Console.WriteLine(12);
            //        break;
            //    case "Wednesday":
            //    case "Thursday":
            //        Console.WriteLine(14);
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        Console.WriteLine(16);
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
