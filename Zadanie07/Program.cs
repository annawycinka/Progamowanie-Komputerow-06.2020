using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };

            int sumaNieparzystych = 0;
            int sumaParzystych = 0;

            foreach (var item in inputArray)
            {
                if (item % 2 == 0)
                {
                    sumaParzystych += item;
                }
                else
                {
                    sumaNieparzystych += item;
                }
            }

            Console.WriteLine($"Suma nieparzystych wynosi: {sumaNieparzystych}");
            Console.WriteLine($"Suma parzystych wynosi: {sumaParzystych}");
        }
    }
}
