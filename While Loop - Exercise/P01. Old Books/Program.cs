using System;

namespace P01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string neededTitle = Console.ReadLine();
            int booksCount = 0;
            string bookName;

            while ((bookName = Console.ReadLine()) != "No More Books" && bookName != neededTitle)
            {
                //if (bookName == neededTitle)
                //{
                //    break;
                //}
                booksCount++;
            }
            if (bookName == neededTitle)
            {
                Console.WriteLine($"You checked {booksCount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksCount} books.");
            }

        }
    }
}
