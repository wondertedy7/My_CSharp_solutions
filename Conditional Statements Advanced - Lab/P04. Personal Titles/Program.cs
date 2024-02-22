using System;

namespace P04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            
            // logic

            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else 
                {
                    Console.WriteLine("Master");
                }
            }
            else
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }

        }
    }
}
