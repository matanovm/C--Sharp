using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Phonebook
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine(); 

			Dictionary<string, string> phonebook = new Dictionary<string, string>(); 


			while (command != "END") 
			{
				string[] splitedCommands = command.Split(' ').ToArray(); 

				if (splitedCommands[0] == "S")
				{
					if (!phonebook.ContainsKey(splitedCommands[1]))
					{
						Console.WriteLine("Contact {0} does not exist.", splitedCommands[1]);
					}
					else
					{
						Console.WriteLine("{0} -> {1}", splitedCommands[1], phonebook[splitedCommands[1]]);
					}
				}
				else
				{
					phonebook[splitedCommands[1]] = splitedCommands[2];
				}

				command = Console.ReadLine(); 
			}
		}
	}
}
