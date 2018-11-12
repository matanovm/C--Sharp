using System;
using System.Collections.Generic;

namespace _06.A_miner_task
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> mats = new Dictionary<string, int>();
			string material = Console.ReadLine();

			while (material != "stop")
			{
				int quantity = 0;

				quantity = int.Parse(Console.ReadLine());

				if (mats.ContainsKey(material))
				{
					mats[material] += quantity;
				}
				else
				{
					mats.Add(material, quantity);
				}
				material = Console.ReadLine();
			}
			PrintSortedResults(mats);
		}

		private static void PrintSortedResults(Dictionary<string, int> mats)
		{
			foreach (KeyValuePair<string, int> materials in mats)
			{
				Console.WriteLine($"{materials.Key} -> {materials.Value}");
			}
		}
	}
}

