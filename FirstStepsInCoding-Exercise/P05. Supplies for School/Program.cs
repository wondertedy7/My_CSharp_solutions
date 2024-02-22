using System;

namespace P05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int penPacksCount = int.Parse(Console.ReadLine());
            int markerPacksCount = int.Parse(Console.ReadLine());
            int detergentLiters = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            // logic

            double penPacksPrice = penPacksCount * 5.80;
            double markerPacksPrice = markerPacksCount * 7.20;
            double detergentPricePerLt = detergentLiters * 1.20;
            double totalPrice = penPacksPrice + markerPacksPrice + detergentPricePerLt;
            double finalPrice = totalPrice - (totalPrice * discountPercent / 100);

            // output

            Console.WriteLine(finalPrice);
        }

    }
}
