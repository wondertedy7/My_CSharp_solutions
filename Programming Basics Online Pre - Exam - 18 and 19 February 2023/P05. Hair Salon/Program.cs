using System;
using System.Threading.Channels;

namespace P05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayTarget = int.Parse(Console.ReadLine());

            int dayProfit = 0;

            int mens = 15;
            int ladies = 20;
            int kids = 10;

            int touchUp = 20;
            int fullColor = 30;

            while (dayProfit < dayTarget)
            {
                string service = Console.ReadLine();

                if (service == "closed")
                {
                    break;
                }
                if (service == "haircut")
                {
                    string type = Console.ReadLine();

                    if (type == "mens")
                    {
                        dayProfit += mens;
                    }
                    else if (type == "kids")
                    {
                        dayProfit += kids;
                    }
                    else if (type == "ladies")
                    {
                        dayProfit += ladies;
                    }
                }
                else if (service == "color")
                {
                    string typeColor = Console.ReadLine();

                    if (typeColor == "touch up")
                    {
                        dayProfit += touchUp;
                    }
                    else if (typeColor == "full color")
                    {
                        dayProfit += fullColor;
                    }
                }
            }
            if (dayProfit >= dayTarget)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {dayProfit}lv.");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {dayTarget - dayProfit}lv. more.");
                Console.WriteLine($"Earned money: {dayProfit}lv.");
            }
        }
    }
}
