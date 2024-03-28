using System;
using System.Text.RegularExpressions;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int daljinaNaTortata = int.Parse(Console.ReadLine());
            int shirinaNaTortata = int.Parse(Console.ReadLine());

            int razmerNaTortata = daljinaNaTortata * shirinaNaTortata;

            int ostavashtaTorta = razmerNaTortata;

            do
            {
                string input = Console.ReadLine();
                bool isNumber = !Regex.IsMatch(input, "\\D");

                int parcheta = 0;
                string command = "";

                if (isNumber)
                {
                    parcheta = int.Parse(input);
                }
                else
                {
                    command = input;
                }

                if (isNumber)
                {
                    ostavashtaTorta -= parcheta;
                }
                if (command == "STOP")
                {
                    break;
                }

            } while (ostavashtaTorta > 0);


            if (ostavashtaTorta >= 0)
            {
                Console.WriteLine($"{ostavashtaTorta} pieces are left.");
            }
            else  // ostavashtaTorta < 0
            {
                int neededPieces = Math.Abs(ostavashtaTorta);
                Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
            }
        }
    }
}
