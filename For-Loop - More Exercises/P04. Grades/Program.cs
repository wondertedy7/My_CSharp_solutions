using System;

namespace P04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double bestStudents = 0;
            double betterStudents = 0;
            double goodStudents = 0;
            double failStudents = 0;
            double averageResult = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    failStudents++;
                }
                else if (grade <= 3.99)
                {
                    goodStudents++;
                }
                else if (grade <= 4.99)
                {
                    betterStudents++;
                }
                else if (grade >= 5.00)
                {
                    bestStudents++;
                }
                averageResult += grade;
            }

            Console.WriteLine($"Top students: {bestStudents / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {betterStudents / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {goodStudents / students * 100:f2}%");
            Console.WriteLine($"Fail: {failStudents / students * 100:f2}%");
            Console.WriteLine($"Average: {averageResult / students:f2}");

        }
    }
}
