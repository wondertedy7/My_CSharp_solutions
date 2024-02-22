using System;
using System.Reflection.Metadata;

namespace P07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int countGroups = int.Parse(Console.ReadLine());

            // logic
            double perMus = 0;
            double perMon = 0;
            double perKil = 0;
            double perK2 = 0;
            double perEv = 0;

            double num;
            double totalNum = 0;

            for (int i = 1; i <= countGroups; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (num <= 5)
                {
                    perMus += num;
                }
                else if (num <= 12)
                {
                    perMon += num;
                }
                else if (num <= 25)
                {
                    perKil += num;
                }
                else if (num <= 40)
                {
                    perK2 += num;
                }
                else
                {
                    perEv += num;
                }

                totalNum += num;

            }

            // output

            Console.WriteLine($"{perMus / totalNum * 100:f2}%");
            Console.WriteLine($"{perMon / totalNum * 100:f2}%");
            Console.WriteLine($"{perKil / totalNum * 100:f2}%");
            Console.WriteLine($"{perK2 / totalNum * 100:f2}%");
            Console.WriteLine($"{perEv / totalNum * 100:f2}%");

        }
    }
}
