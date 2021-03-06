﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_of_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ab = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Dictionary<int, int> numbersN = new Dictionary<int, int>();
			Dictionary<int, int> numbersM = new Dictionary<int, int>();

			for (int i = 0; i < ab[0]; i++)
			{
				int nNumber = int.Parse(Console.ReadLine());
				if (!numbersN.ContainsKey(nNumber))
					numbersN.Add(nNumber, 1);
			}

			for (int i = 0; i < ab[1]; i++)
			{
				int mNumber = int.Parse(Console.ReadLine());
				if (!numbersM.ContainsKey(mNumber))
					numbersM.Add(mNumber, 1);
			}

			foreach (var nnumber in numbersN)
			{
				int key = nnumber.Key;
				if (numbersM.ContainsKey(key)) Console.Write(key + " ");
			}

		}
	}
}
