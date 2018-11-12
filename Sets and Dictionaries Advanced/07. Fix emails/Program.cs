using System;
using System.Collections.Generic;

namespace _07.Fix_emails
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			Dictionary<string, string> emails = new Dictionary<string, string>();
			while (name != "stop")
			{
				string email = Console.ReadLine();
				string ends = email.Substring(email.Length - 2, 2).ToLower();
				if (ends != "uk" && ends != "us")
				{
					emails.Add(name, email);
				}
				name = Console.ReadLine();
			}
			foreach (var pair in emails)
			{
				Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
			}
		}
	}
}

