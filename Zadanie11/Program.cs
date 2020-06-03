using System;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            //a1x+b1y=c1
            var a1 = 1;
            var b1 = 2;
            var c1 = 3;

            //a2x+b2y=c2
            var a2 = 4;
            var b2 = 5;
            var c2 = 6;

            var w = a1 * b1 - b1 * a2;
            var wx = c1 * b2 - b1 * c2;
            var wy = a1 * c2 - c1 * a2;

            string numberOfSolutions = "niewiadomo";
            if (w != 0)
            {
                numberOfSolutions = "1";
            }
            else if (w == 0 && wx == 0 && wy == 0)
            {
                numberOfSolutions = "nieskończoność";
            }
            else if (w == 0 && wx != 0 && wy != 0)
            {
                numberOfSolutions = "0";
            }


            Console.WriteLine("Liczba rozwiązań układu równań: " + numberOfSolutions);

        }
    }
}
