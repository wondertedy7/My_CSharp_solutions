using System;

namespace P06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int protector = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            // logic

            double protectorAmount = (protector + 2) * 1.50;
            double paintAmount = (paint + (paint * 0.10)) * 14.50;
            double bags = 0.40;
            double paintThinnerAmount = paintThinner * 5.00;
            double allMaterialsExpenses = protectorAmount + paintAmount + bags + paintThinnerAmount;
            double workersFee = (allMaterialsExpenses * 0.30) * workingHours;
            double finalAmount = allMaterialsExpenses + workersFee;

            // output

            Console.WriteLine(finalAmount);

        }
    }
}
