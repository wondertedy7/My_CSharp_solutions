using System;
using System.Security.Cryptography.X509Certificates;

namespace P02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int degrees = int.Parse(Console.ReadLine());
            string partOfday = Console.ReadLine();

            // logic

            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <=18)
            {
                if (partOfday == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (partOfday == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
                else if (partOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (partOfday == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfday == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees >= 25)
            {
                if (partOfday == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfday == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            // output

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
