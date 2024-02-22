using System;

namespace P03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string typeFlower = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // logic

            double price = 0;

            //if (typeFlower == "Roses")
            //{
            //    price = countFlowers * 5;

            //    if (countFlowers > 80)
            //    {
            //        price -= price * 0.1;
            //    }

            //}
            //else if (typeFlower == "Dahlias")
            //{
            //    price = countFlowers * 3.80;

            //    if (countFlowers > 90)
            //    {
            //        price -= price * 0.15;
            //    }

            //}

            //else if (typeFlower == "Tulips")
            //{
            //    price = countFlowers * 2.80;

            //    if (countFlowers > 80)
            //    {
            //        price -= price * 0.15;
            //    }

            //}

            //else if (typeFlower == "Narcissus")
            //{
            //    price = countFlowers * 3;

            //    if (countFlowers < 120)
            //    {

            //        price += price * 0.15;
            //    }

            //}

            //else if (typeFlower == "Gladiolus")
            //{
            //    price = countFlowers * 2.50;

            //    if (countFlowers < 80)
            //    {
            //        price += price * 0.20;
            //    }

            //}

            switch (typeFlower)
            {
                case "Roses":
                    if (countFlowers > 80)
                    {
                        price = countFlowers * (5 - 5 * 0.1);
                    }
                    else
                    {
                        price = countFlowers * 5;
                    }
                    break;
                case "Dahlias":
                    if (countFlowers > 90)
                    {
                        price = countFlowers * (3.80 - 3.80 * 0.15);
                    }
                    else
                    {
                        price = countFlowers * 3.80;
                    }
                    break;
                case "Tulips":
                    if (countFlowers > 80)
                    {
                        price = countFlowers * (2.80 - 2.80 * 0.15);
                    }
                    else
                    {
                        price = countFlowers * 2.80;
                    }
                    break;
                case "Narcissus":
                    if (countFlowers < 120)
                    {
                        price = countFlowers * (3 + 3 * 0.15);
                    }
                    else
                    {
                        price = countFlowers * 3;
                    }
                    break;
                case "Gladiolus":
                    if (countFlowers < 80)
                    {
                        price = countFlowers * (2.50 + 2.50 * 0.20);
                    }
                    else
                    {
                        price = countFlowers * 2.50;
                    }
                    break;
            }


            // output

            // double total = countFlowers * price;

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlower} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
            }
        }
    }
}
