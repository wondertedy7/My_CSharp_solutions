using System;

namespace P07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int chickenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int veggieMenuCount = int.Parse(Console.ReadLine());

            // logic

            double chickenMenuPrice = chickenMenuCount * 10.35;
            double fishMenuPrice = fishMenuCount * 12.40;
            double veggieMenuPrice = veggieMenuCount * 8.15;
            double desertPrice = (chickenMenuPrice + fishMenuPrice + veggieMenuPrice) * 0.20;
            double deliveryPrice = 2.50;
            double totalPrice = chickenMenuPrice + fishMenuPrice + veggieMenuPrice + desertPrice + deliveryPrice;


            // output

            Console.WriteLine(totalPrice);
        }
    }
}
