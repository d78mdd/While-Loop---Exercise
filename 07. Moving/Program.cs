using System;
using System.Text.RegularExpressions;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int daljinaNaSvobodnoMiasto = int.Parse(Console.ReadLine());
            int shirinaNaSvobodnoMiasto = int.Parse(Console.ReadLine());
            int dalbochinaNaSvobodnoMiasto = int.Parse(Console.ReadLine());

            int razmerNaSvobodnoMiasto = daljinaNaSvobodnoMiasto * shirinaNaSvobodnoMiasto * dalbochinaNaSvobodnoMiasto;

            int ostavashtoSvobodnoMiasto = razmerNaSvobodnoMiasto;

            string command;

            do
            {
                string input = Console.ReadLine();
                bool isNumber = !Regex.IsMatch(input, "\\D");

                int kashoni = 0;
                command = "";

                if (isNumber)
                {
                    kashoni = int.Parse(input);
                }
                else
                {
                    command = input;
                }

                if (isNumber)
                {
                    ostavashtoSvobodnoMiasto -= kashoni;
                }

            } while (ostavashtoSvobodnoMiasto > 0 && command != "Done");


            if (ostavashtoSvobodnoMiasto >= 0)
            {
                Console.WriteLine($"{ostavashtoSvobodnoMiasto} Cubic meters left.");
            }
            else  // ostavashtoSvobodnoMiasto < 0
            {
                int nujnoMiasto = Math.Abs(ostavashtoSvobodnoMiasto);
                Console.WriteLine($"No more free space! You need {nujnoMiasto} Cubic meters more.");
            }
        }
    }
}
