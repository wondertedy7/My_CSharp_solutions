using System;

namespace P03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double busCargo = 0;
            double truckCargo = 0;
            double trainCargo = 0;
            double allCargo = 0;
            double averagePrice = 0;

            for (int i = 1; i <= n; i++)
            {
                double cargo = double.Parse(Console.ReadLine());

                if (cargo <= 3)
                {
                    busCargo += cargo;
                }
                else if (cargo <= 11)
                {
                    truckCargo += cargo;
                }
                else if (cargo >= 12)
                {
                    trainCargo += cargo;
                }
            }
            allCargo = busCargo + truckCargo + trainCargo;
            averagePrice = (busCargo * 200 + truckCargo * 175 + trainCargo * 120) / allCargo;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{busCargo / allCargo * 100:f2}%");
            Console.WriteLine($"{truckCargo / allCargo * 100:f2}%");
            Console.WriteLine($"{trainCargo / allCargo * 100:f2}%");

        }
    }
}
