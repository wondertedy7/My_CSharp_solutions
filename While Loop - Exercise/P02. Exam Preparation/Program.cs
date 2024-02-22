using System;

namespace P02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGradesCount = int.Parse(Console.ReadLine());
            string problems;
            int grade;
            int numProblems = 0;
            string lastProblem = "";
            int poorGrade = 0;
            double allGrades = 0;

            while ((problems = Console.ReadLine()) != "Enough")
            {
                numProblems++;
                grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    poorGrade++;
                }
                if (poorGrade == poorGradesCount)
                {
                    break;
                }
                allGrades += grade;
                lastProblem = problems;

            }
            if (poorGrade == poorGradesCount)
            {
                Console.WriteLine($"You need a break, {poorGrade} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {allGrades / numProblems:f2}");
                Console.WriteLine($"Number of problems: {numProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
