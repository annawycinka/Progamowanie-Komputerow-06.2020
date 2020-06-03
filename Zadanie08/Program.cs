using System;

namespace Zadanie8
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

            Array.Sort(inputArray);

            var diffBetween1and2item = inputArray[1] - inputArray[0];
            bool isArithmeticProgression = true;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] - inputArray[i - 1] != diffBetween1and2item)
                {
                    isArithmeticProgression = false;
                }
            }

            Console.WriteLine($"Czy podane liczby sa w stanie utworzyc ciag arytemtyczny?: {isArithmeticProgression}");
        }
    }
}
