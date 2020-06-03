using System;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyznaczy miejsca zerowe funkcji kwadratowej (f(x) = ax^2 + bx + c) oraz współrzędne wierzchołka funkcji.");

            Console.WriteLine("Podaj a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            double sqrtDelta = Math.Sqrt(delta);

            Console.WriteLine("Miejsca zerowe funkcji: ");
            if (sqrtDelta == 0)
            {
                Console.WriteLine("x = " + (-b / (2 * a)));
            }
            else if (sqrtDelta > 0)
            {
                Console.WriteLine("x1 = " + ((-b - sqrtDelta) / (2 * a)));
                Console.WriteLine("x2 = " + ((-b + sqrtDelta) / (2 * a)));
            }
            else
            {
                Console.WriteLine("Nie ma miejsc zerowych");
            }

            var x = -b / (2 * a);
            var y = -delta / (4 * a);

            Console.WriteLine($"Wierchołek funkcji ma współrzędne: x = {x}, y = {y}");

        }
    }
}
