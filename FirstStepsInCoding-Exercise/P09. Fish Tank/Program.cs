using System;

namespace P09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());  
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            // logic

            int volume = lenght * width * hight;
            double liters = volume * 0.001;
            double finalVolume = liters - liters * percent / 100;

            // output

            Console.WriteLine(finalVolume);
            

        }   
            

    }
}
