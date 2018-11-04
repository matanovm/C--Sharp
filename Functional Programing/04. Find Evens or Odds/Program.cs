using System;
using System.Linq;


namespace _04.Find_Evens_or_Odds
{
	class Program
	{
		static void Main(string[] args)
		{

			Predicate<string> isOdd = x => x == "odd";
			Predicate<string> isEven = x => x == "even";
			int[] bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			string type = Console.ReadLine();

			if (isOdd.Invoke(type))
			{
				for (int i = bounds[0]; i <= bounds[1]; i++)
				{
					if (i % 2 != 0)
						Console.Write(i + " ");
				}
			}

			if (isEven.Invoke(type))
			{
				for (int i = bounds[0]; i <= bounds[1]; i++)
				{
					if (i % 2 == 0)
						Console.Write(i + " ");
				}
			}

			Console.WriteLine();
		}
	}
}

