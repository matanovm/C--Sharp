﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.Custom_Comparator
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> isDivesible1 = x => x % 2 != 0;
			Predicate<int> isDivesible2 = x => x % 2 == 0;

			List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			List<int> evenNumbers = new List<int>();
			List<int> oddNumbers = new List<int>();

			foreach (int number in input)
			{
				if (isDivesible1.Invoke(number))
				{
					oddNumbers.Add(number);
				}

				else if (isDivesible2.Invoke(number))
				{
					evenNumbers.Add(number);
				}
			}

			oddNumbers.Sort();
			evenNumbers.Sort();

			foreach (var even in evenNumbers)
			{
				Console.Write(even + " ");
			}

			foreach (var odd in oddNumbers)
			{
				Console.Write(odd + " ");
			}
		}
	}
}
