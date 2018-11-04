using System;
using System.IO;

namespace _01._Odd_Lines
{
	class Program
	{
		static void Main()
		{
			string path = @"D:\GitHub_Repository\C--Sharp\Streams\Streams\01. Odd numbers\text.txt";
			using (var stream = new StreamReader(path))
			{
				var lineNumber = 0;

				string line;
				while ((line = stream.ReadLine()) != null)
				{
					if (lineNumber % 2 == 1)
					{
						Console.WriteLine(line);

					}
					lineNumber++;
				}

			}
		}
	}
}
