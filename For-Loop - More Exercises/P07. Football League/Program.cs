using System;

namespace P07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());

            int fansA = 0; 
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;

            for (int i = 1; i <= fansCount; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A':
                        fansA++;
                        break;
                    case 'B':
                        fansB++;
                        break;
                    case 'V':
                        fansV++;
                        break;
                    case 'G':
                        fansG++;
                        break;
                }
            }
            Console.WriteLine($"{(double)fansA / fansCount * 100:f2}%");
            Console.WriteLine($"{(double)fansB / fansCount * 100:f2}%");
            Console.WriteLine($"{(double)fansV / fansCount * 100:f2}%");
            Console.WriteLine($"{(double)fansG / fansCount * 100:f2}%");
            Console.WriteLine($"{(double)fansCount / stadiumCapacity * 100:f2}%");
        }
    }

}
