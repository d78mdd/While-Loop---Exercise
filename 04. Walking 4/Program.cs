using System;
using System.Text.RegularExpressions;

namespace _04.Walking_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;

            int expectedSteps = 10000;

            do
            {
                string input = Console.ReadLine();
                bool isNumber = !Regex.IsMatch(input, "\\D");

                int steps = 0;
                string command = "";

                if (isNumber)
                {
                    steps = int.Parse(input);
                }
                else
                {
                    command = input;
                }

                if (isNumber)
                {
                    totalSteps += steps;
                }
                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }

            } while (totalSteps < expectedSteps);


            if (totalSteps >= expectedSteps)
            {
                int stepsDifference = totalSteps - expectedSteps;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsDifference} steps over the goal!");
            }
            else
            {
                int stepsDifference = expectedSteps - totalSteps;
                Console.WriteLine($"{stepsDifference} more steps to reach goal.");
            }
        }
    }
}
