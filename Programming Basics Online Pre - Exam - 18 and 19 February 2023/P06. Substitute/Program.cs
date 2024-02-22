using System;

namespace P06._Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int counter = 0;            
            bool end = false;

            for (int num1FirstDig = K; num1FirstDig <= 8; num1FirstDig++)
            {
                for (int num1SecondDig = 9; num1SecondDig >= L; num1SecondDig--)
                {
                    for (int num2FirstDig = M; num2FirstDig <= 8; num2FirstDig++)
                    {
                        for (int num2SecDig = 9; num2SecDig >= N; num2SecDig--)
                        {
                            bool valid = num1FirstDig % 2 == 0 && num1SecondDig % 2 != 0 && num2FirstDig % 2 == 0 && num2SecDig % 2 != 0;

                            int num1 = num1FirstDig * 10 + num1SecondDig;
                            int num2 = num2FirstDig * 10 + num2SecDig;

                            if (valid && num1 == num2)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else if (valid && num1 != num2)
                            {
                                Console.WriteLine($"{num1FirstDig}{num1SecondDig} - {num2FirstDig}{num2SecDig}");
                                counter++;
                            }
                            if (counter >= 6)
                            {
                                end = true;                                
                            }
                            if (end)
                            {
                                break;
                            }

                        }
                        if (end)
                        {
                            break;
                        }
                    }
                    if (end)
                    {
                        break;
                    }
                }
                if (end)
                {
                    break;
                }
            }

        }
    }
}
