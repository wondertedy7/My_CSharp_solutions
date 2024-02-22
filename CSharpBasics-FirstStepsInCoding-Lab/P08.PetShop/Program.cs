using System;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDogFood = int.Parse(Console.ReadLine());
            int countCatFood = int.Parse(Console.ReadLine());

            double priceDogFod = 2.50;
            int priceCatFood = 4;
            double totalPrice = (countDogFood * priceDogFod) + (countCatFood * priceCatFood);

            Console.WriteLine($"{totalPrice} lv.");



        }
    }
}
