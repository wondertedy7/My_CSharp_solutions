using System;

namespace P05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double finalResult = 0;
            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;
            double invalidNumbers = 0;
            
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    finalResult += num * 0.2;
                    from0to9++;
                }
                else if (num <= 19 && num >=10)
                {
                    finalResult += num * 0.3;
                    from10to19++;
                }
                else if (num <= 29 && num >= 20)
                {
                    finalResult += num * 0.4;
                    from20to29++;
                }
                else if (num <= 39 && num >= 30)
                {
                    finalResult += 50;
                    from30to39++;
                }
                else if (num <= 50 && num >= 40)
                {
                    finalResult += 100;
                    from40to50++;
                }
                else if (num < 0 || num > 50)
                {
                    finalResult /= 2;
                    invalidNumbers++;
                }
            }

            Console.WriteLine($"{finalResult:f2}");
            Console.WriteLine($"From 0 to 9: {from0to9 / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {from10to19 / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {from20to29 / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {from30to39 / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {from40to50 / n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers / n * 100:f2}%");



        }
    }
}
