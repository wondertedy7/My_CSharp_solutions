using System;

namespace P06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int piecesCount = width * length;
            //int cakeLeft = 0;
            string command;
            
            while ((command = Console.ReadLine()) != "STOP")
            {
                int pieces = int.Parse(command);
                piecesCount -= pieces;

                if (piecesCount < 0)
                {
                    break;
                }

            }
            if (piecesCount >= 0)
            {
                Console.WriteLine($"{piecesCount} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCount)} pieces more.");
            }
        }
    }
}
