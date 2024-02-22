using System;

namespace P03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            double primeSum = 0;
            double nonPrimeSum = 0;
            double num;

            while ((input = Console.ReadLine()) != "stop")
            {
                num = double.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool isPrime = true;
                for (int i = 2; i <= num -1; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
