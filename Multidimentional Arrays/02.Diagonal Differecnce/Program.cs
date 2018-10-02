using System;
using System.Linq;

namespace _02.Diagonal_Differecnce
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] matrix = new long[n][];

            for (int i = 0; i < n; i++)

            {

                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            }

            long sumFirst = 0;
            long sumSecond = 0;

            for (int row = 0; row < n; row++)
            {
                sumFirst += matrix[row][row];
               
            }

            for (int row = 0, col = n - 1; row < n; row++, col--)
            {
                sumSecond += matrix[row][col];
            }
          
            Console.WriteLine(Math.Abs(sumFirst - sumSecond)); 
           
        }
    }
}
