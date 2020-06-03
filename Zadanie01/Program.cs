using System;

namespace Zadania_zaliczeniowe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Podaj pierwszą liczbę:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = Convert.ToInt32(Console.ReadLine());

            sprawdzCzyPodzielnaPrzez(liczba: a, podzielnik: 2);
            sprawdzCzyPodzielnaPrzez(a, 3);
            sprawdzCzyPodzielnaPrzez(b, 2);
            sprawdzCzyPodzielnaPrzez(b, 3);

            Console.ReadLine();
        }

        private static void sprawdzCzyPodzielnaPrzez(int liczba, int podzielnik)
        {
            if (liczba % podzielnik == 0)
            {
                Console.WriteLine($"Liczba {liczba} jest podzielna przez {podzielnik}");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba} jest niepodzielna przez {podzielnik}");
            }
        }
    }
}