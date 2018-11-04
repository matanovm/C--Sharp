using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Advanced_Exercises
{
	class ReverceNumbers
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			var stack = new Stack<int>(input);

			Console.WriteLine(string.Join(" ", stack));
		}
	}
}