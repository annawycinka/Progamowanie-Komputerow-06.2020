using System;

namespace Zadanie5
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
                6
            };

            Console.WriteLine($"{string.Join(',', inputArray)}");

            int iloczyn = 1;

            foreach (var item in inputArray)
            {
                if (item > 0 && item % 3 == 0)
                {
                    iloczyn *= item;
                }
            }

            Console.WriteLine($"Iloczyn wynosi: {iloczyn}");
        }
    }
}
