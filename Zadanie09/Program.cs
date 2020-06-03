using System;

namespace Zadanie9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrixA = new[,]
            {
                { 1,2,3 },
                { 1,2,3 },
                { 1,2,3 },
            };


            var iloczyn = 1;

            foreach (var item in matrixA)
            {
                Console.Write($"{item},");

                if (item % 3 == 0 || item % 4 == 0)
                {
                    iloczyn *= item;
                }
            }

            Console.WriteLine($"Iloczyn wynosi: {iloczyn}");
        }
    }
}