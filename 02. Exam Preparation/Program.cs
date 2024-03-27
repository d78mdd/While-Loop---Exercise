using System;

namespace _02.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                double problemGrade = double.Parse(Console.ReadLine());
                if (problemGrade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += problemGrade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            }
            else
            {
                double average = gradesSum / solvedProblemsCount;
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
