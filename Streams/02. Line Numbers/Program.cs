using System;
using System.IO;

namespace _02._Line_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"D:\GitHub_Repository\C--Sharp\Streams\Streams\01. Odd numbers\text.txt";
			string newPath = @"D:\GitHub_Repository\C--Sharp\Streams\Streams\02. Line Numbers\newFile.txt";
			using (var stream = new StreamReader(path))
			{
				using (var writer = new StreamWriter(newPath))
				{
					var lineNumber = 1;

					string line;
					while ((line = stream.ReadLine()) != null)
					{
						writer.WriteLine($"Line {lineNumber} : " + line);
						lineNumber++;
					}
				}
			}
		}
	}
}
