using System;
using System.Linq;


namespace _01.Action_Point
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine($"Sir {message}");
			var input = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			foreach (var word in input)
			{
				print(word);
			}
		}
	}
}
