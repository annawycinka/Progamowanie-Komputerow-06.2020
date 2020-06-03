using System;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku dla macierzy kwadratowych A i B");
            int sideLength = int.Parse(Console.ReadLine());

            var matrixA = CreateSquareMatrix(sideLength);
            PrintMatrix(matrixA, "Macierz A");

            var matrixB = CreateSquareMatrix(sideLength);
            PrintMatrix(matrixB, "Macierz B");

            var matrixSum = SumMatrixes(matrixA, matrixB);
            PrintMatrix(matrixSum, "Suma macierzy A i B");

            var matrixProduct = MultiplyMatrixes(matrixA, matrixB);
            PrintMatrix(matrixProduct, "Iloczyn macierzy A i B");
        }

        static int[,] CreateSquareMatrix(int sideLength)
        {
            var matrix = new int[sideLength, sideLength];

            for (int row = 0; row < sideLength; row++)
            {
                for (int column = 0; column < sideLength; column++)
                {
                    matrix[row, column] = 3;
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix, string matrixName)
        {
            Console.WriteLine("Matrix: " + matrixName);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] SumMatrixes(int[,] matrix1, int[,] matrix2)
        {
            var matrixToReturn = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int column = 0; column < matrix1.GetLength(1); column++)
                {
                    matrixToReturn[row, column] = matrix1[row, column] + matrix2[row, column];
                }
            }

            return matrixToReturn;
        }

        static int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
        {
            var matrixToReturn = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int column = 0; column < matrix1.GetLength(1); column++)
                {
                    matrixToReturn[row, column] = matrix1[row, column] * matrix2[row, column];
                }
            }

            return matrixToReturn;
        }
    }
}
