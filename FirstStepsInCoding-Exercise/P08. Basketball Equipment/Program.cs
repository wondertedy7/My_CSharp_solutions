using System;

namespace P08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int yearFee = int.Parse(Console.ReadLine());

            // logic

            double shoes = yearFee - yearFee * 0.40;
            double suit = shoes - shoes * 0.20;
            double ball = suit / 4;
            double accessories = ball / 5;
            double fullExpences = yearFee + shoes + suit + ball + accessories;

            // output

            Console.WriteLine(fullExpences);
        }
    }
}
