using System;

namespace P07._Safe_Passwords_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPassCount = int.Parse(Console.ReadLine());


            char A = (char)35;
            char B = (char)64;
            bool flag = false;
            int counter = 0;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    Console.Write($"{A}{B}{x}{y}{B}{A}|");
                    counter++;
                    A++;
                    B++;

                    if (counter >= maxPassCount)
                    {
                        flag = true;
                        break;
                    }
                    if (A > 55)
                    {
                        A = (char)35;
                    }
                    if (B > 96)
                    {
                        B = (char)64;
                    }
                }
                if (flag)
                {
                    break;
                }

            }

        }
    }
}
