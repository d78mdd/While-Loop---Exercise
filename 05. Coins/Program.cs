using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int inputStotinki = (int)(input * 100);

            int leftSum = inputStotinki;

            int moneta2lv = 200;
            int moneta1lv = 100;
            int moneta50st = 50;
            int moneta20st = 20;
            int moneta10st = 10;
            int moneta5st = 5;
            int moneta2st = 2;
            int moneta1st = 1;

            int broiMoneti = 0;

            do
            {
                int broiOtMonetata;

                if (leftSum >= moneta2lv)
                {
                    broiOtMonetata = leftSum / moneta2lv;
                    leftSum -= moneta2lv * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta1lv)
                {
                    broiOtMonetata = leftSum / moneta1lv;
                    leftSum -= moneta1lv * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta50st)
                {
                    broiOtMonetata = leftSum / moneta50st;
                    leftSum -= moneta50st * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta20st)
                {
                    broiOtMonetata = leftSum / moneta20st;
                    leftSum -= moneta20st * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta10st)
                {
                    broiOtMonetata = leftSum / moneta10st;
                    leftSum -= moneta10st * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta5st)
                {
                    broiOtMonetata = leftSum / moneta5st;
                    leftSum -= moneta5st * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta2st)
                {
                    broiOtMonetata = leftSum / moneta2st;
                    leftSum -= moneta2st * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else if (leftSum >= moneta1st)
                {
                    broiOtMonetata = leftSum / moneta1st;
                    leftSum -= moneta1st * broiOtMonetata;
                    broiMoneti += broiOtMonetata;
                }
                else
                {
                    Console.WriteLine("error");
                }

            } while (leftSum != 0);


            Console.WriteLine(broiMoneti);

        }
    }
}
