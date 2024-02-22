using System;

namespace P10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int number = int.Parse(Console.ReadLine());

            // logic

            //bool isValid = number >= 100 && number <= 200 || number == 0; 
            //if (!isValid)
            //{
            //    Console.WriteLine("invalid");
            //}

            if (!( number >= 100 && number <= 200 || number == 0 ))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
