using System;

namespace P02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. четем радиани от конзолатa
            double radians = double.Parse(Console.ReadLine());

            //2. преобразуваме от радиани в градуси (градус = радиан * 180 / π)
            double degrees = radians * 180 /Math.PI;

            //3. отпечатваме градусите на конзолата
            Console.WriteLine(degrees);

        }
    }
}
