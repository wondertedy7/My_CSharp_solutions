using System;

namespace P06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            // logic

            double result = 0;

            switch (oper)
            {
                case "+":
                    result = N1 + N2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} + {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} + {N2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} - {N2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - odd");
                    }
                    break;
            }

            // output

            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (oper == "/")
            {
                result = N1 / N2;
                Console.WriteLine($"{N1} / {N2} = {result:f2}");
            }
            else if (oper == "%")
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} % {N2} = {result}");
            }
        }
    }
}
