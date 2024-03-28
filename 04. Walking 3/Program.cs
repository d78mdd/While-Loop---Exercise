using System;

namespace _04.Walking_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps;

            int totalSteps = 0;

            int expectedSteps = 10000;

            string stepsOrCommand;
            do
            {
                stepsOrCommand = Console.ReadLine();
                if (stepsOrCommand == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }
                else if (int.Parse(stepsOrCommand) > int.MinValue &&
                         int.Parse(stepsOrCommand) < int.MaxValue)
                {
                    steps = int.Parse(stepsOrCommand);
                    totalSteps += steps;
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
