﻿using System;
using System.Linq;


namespace _05.Applied_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			Func<int, int> add = x => x + 1;
			Func<int, int> multiply = x => x * 2;
			Func<int, int> subtract = x => x - 1;
			Action<int> print = x => Console.Write(x + " ");
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			string command = "";

			while (command != "end")
			{
				command = Console.ReadLine();

				switch (command)
				{
					case "add":
						{
							foreach (var number in input)
							{
								input[n] = (add(number));
								n++;
							}
							n = 0;
						}
						break;
					case "multiply":
						{
							foreach (var number in input)
							{
								input[n] = (multiply(number));
								n++;
							}
							n = 0;
						}
						break;
					case "subtract":
						{
							foreach (var number in input)
							{
								input[n] = (subtract(number));
								n++;
							}
							n = 0;
						}
						break;
					case "print":
						{
							foreach (var number in input)
							{
								print(number);
							}
							Console.WriteLine();
						}
						break;
				}
			}
			Environment.Exit(0);
		}
	}
}
