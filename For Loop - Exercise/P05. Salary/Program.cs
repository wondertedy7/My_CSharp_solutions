using System;
using System.Security.Cryptography.X509Certificates;

namespace P05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input

            int tabsCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string site;

            // logic

            for (
                int tab = 0; tab <= tabsCount; tab++)
            {
                site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary -= 150;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }
                
                
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
            }
            // output

            if (salary > 0 )
            {
                Console.WriteLine(salary);
            }
        }
    }
}
