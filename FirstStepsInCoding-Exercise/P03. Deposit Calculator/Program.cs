using System;

namespace P03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine())/100;

            // logic
            double sum = deposit + term * ((deposit * rate) / 12);

            // output
            Console.WriteLine(sum);
             
        }
    }
}
