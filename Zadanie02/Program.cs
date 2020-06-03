using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int liczba = 100; liczba <= 999; liczba++)
            {
                string liczbaString;
                liczbaString = Convert.ToString(liczba);
                if ((liczbaString[0] != liczbaString[1]) &&
                    (liczbaString[1] != liczbaString[2]) &&
                    (liczbaString[0] != liczbaString[2]))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
