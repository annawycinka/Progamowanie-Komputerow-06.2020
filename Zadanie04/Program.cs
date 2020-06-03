using System;
using System.Linq;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = new double[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8
            };

            Console.WriteLine($"{string.Join(',', inputArray)}");

            var minElement = inputArray.Min();

            var minElementIndex = Array.IndexOf(inputArray, minElement);

            Console.WriteLine($"Min elemnt: {minElement}, min element index: {minElementIndex}");
        }
    }
}
