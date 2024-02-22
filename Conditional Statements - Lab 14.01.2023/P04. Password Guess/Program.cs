using System;

namespace P04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            string password = Console.ReadLine();

            // output
            
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
