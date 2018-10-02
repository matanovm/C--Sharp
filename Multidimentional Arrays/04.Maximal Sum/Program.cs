using System;
using System.Linq;

namespace _04.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = InitializeMatrix();

            PrintMatrixBiggestSum3x3(matrix);

        }

        private static void PrintMatrixBiggestSum3x3(int[][] matrix)

        {

            var biggestSum = int.MinValue;
            var result = new int[2];

            for (int i = 0; i < matrix.Length - 2; i++)
            {

                for (int j = 0; j < matrix[i].Length - 2; j++)

                {
                    var testSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                        matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] +
                        matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];


                    if (testSum > biggestSum )

                    {
                        biggestSum = testSum;
                        result[0] = i;
                        result[1] = j;

                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            Console.WriteLine(string.Join(Environment.NewLine, matrix
                .Skip(result[0])
                .Take(3)
                .Select(row => string.Join(" ", row.Skip(result[1]).Take(3)))));



        }


        private static int[][] InitializeMatrix()

        {

            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new int[dimensions[0]][];
            for (int i = 0; i < matrix.Length; i++)

            {

                matrix[i] = Console.ReadLine().Split().Take(dimensions[1]).Select(int.Parse).ToArray();

            }

            return matrix;

        }
    }
}
