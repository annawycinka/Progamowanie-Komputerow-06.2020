using System;

namespace Zadanie6
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
                7
            };

            Console.WriteLine($"{string.Join(',', inputArray)}");

            int sum = 0;

            foreach (var item in inputArray)
            {
                if (item <= 0 || item % 4 == 2)
                {
                    sum += item * item;
                }
            }

            Console.WriteLine($"Suma wynosi: {sum}");
        }
    }
}
