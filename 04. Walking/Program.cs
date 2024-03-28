using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;

            int totalSteps = 0;

            int expectedSteps = 10000;

            string stepsOrCommand;
            do
            {
                stepsOrCommand = Console.ReadLine();

                if (stepsOrCommand != "Going home")
                {
                    steps = int.Parse(stepsOrCommand);
                    totalSteps += steps;
                }

            } while (stepsOrCommand != "Going home" && totalSteps < expectedSteps);


            if (stepsOrCommand == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalSteps += stepsToHome;
            }

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
