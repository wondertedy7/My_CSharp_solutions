using System;

namespace P01._Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatPercent = int.Parse(Console.ReadLine());
            int proteinsPercent = int.Parse(Console.ReadLine());
            int carbsPercent = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int waterPercent = int.Parse(Console.ReadLine());

            int fat = 9;
            int proteins = 4;
            int carbs = 4;

            double fatWeight = (totalCalories * fatPercent)/ 100 / (double)fat;
            double proteinWeight = (totalCalories * proteinsPercent) / 100 / (double)proteins;
            double carbsWeight = totalCalories * carbsPercent / 100 / (double)carbs;

            double totalWeight = fatWeight + proteinWeight + carbsWeight;
            double caloriesPerGram = totalCalories / totalWeight;
            double calories = caloriesPerGram * waterPercent / 100;
            double pureCalories = caloriesPerGram - calories;

            Console.WriteLine($"{pureCalories:f4}");
            



        }
    }
}
