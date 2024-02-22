using System;

namespace P01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumBorder = int.Parse(Console.ReadLine());
            int secondNumBorder = int.Parse(Console.ReadLine());
            int thirdNumBorder = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            for (int i = 2; i <= firstNumBorder; i += 2)
            {
                for (int j = 2; j <= secondNumBorder; j++)
                {
                    for (int k = 2; k <= thirdNumBorder; k += 2)
                    {
                        int num = j;
                        bool isPrime = true;

                        for (int n = 2; n <= num - 1; n++)
                        {
                            if (num % n == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            num1 = i;
                            num2 = num;
                            num3 = k;
                            Console.WriteLine($"{num1} {num2} {num3}");
                        }
                    }
                }
            }
        }
    }
}
