using System;
using System.Linq;

namespace _06.Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Func<int, int, int> isDivisible = (int x, int b) => x % n;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (isDivisible(input[i], n) != 0)
                {
                    Console.Write(input[i] + " ");
                }
            }
            }
    }
}
