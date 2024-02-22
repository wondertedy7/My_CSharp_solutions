using System;

namespace P09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yardM2 = double.Parse(Console.ReadLine());

            double priceM2 = 7.61;
            double yardPrice = yardM2 * priceM2;
            double discount = 0.18 * yardPrice;
            double finalPrice = yardPrice - discount; 



            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");






        }
    }
}
