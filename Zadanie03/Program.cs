using System;
using System.Collections.Generic;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var selectedNumbers = new List<int>();
            do
            {
                var newNumber = random.Next(1, 49);

                if (!selectedNumbers.Contains(newNumber))
                {
                    selectedNumbers.Add(newNumber);
                }
            } while (selectedNumbers.Count < 6);

            Console.WriteLine($"Selected numbers: {string.Join(',', selectedNumbers)}");
        }
    }
}
