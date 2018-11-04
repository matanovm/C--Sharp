using System;
using System.IO;
namespace WordCount
{
	class Program
	{

		static void Main(string[] args)
		{
			using (var readStream = new StreamReader(@"D:\GitHub_Repository\C--Sharp\Streams\03. Word Count\text.txt"))
			{
				using (var readWords = new StreamReader(@"D:\GitHub_Repository\C--Sharp\Streams\03. Word Count\words.txt"))
				{
					using (var writeStream = new StreamWriter(@"D:\GitHub_Repository\C--Sharp\Streams\03. Word Count\result.txt"))
					{
						int times1 = 0, times2 = 0, times3 = 0;
						string firstWord = readWords.ReadLine();
						string secondWord = readWords.ReadLine();
						string thirdWord = readWords.ReadLine();
						string line;

						while ((line = readStream.ReadLine()) != null)
						{
							line = line.ToLower();
							string[] input = line.Split(' ');

							for (int i = 0; i < input.Length; i++)
							{
								if (firstWord == input[i].ToLower()) times1++;

								if (secondWord == input[i].ToLower()) times2++;


								if ((thirdWord + '.') == input[i].ToLower()) times3++;
							}

						}

						if (times1 > times2 && times1 > times3)
						{
							writeStream.WriteLine(firstWord + " - " + times1);

							if (times2 > times3)
							{
								writeStream.WriteLine(secondWord + " - " + times2);
								writeStream.WriteLine(thirdWord + " - " + times3);
							}
							else
							{
								writeStream.WriteLine(thirdWord + " - " + times3);
								writeStream.WriteLine(secondWord + " - " + times2);
							}
						}

						else if (times2 > times1 && times2 > times3)
						{
							writeStream.WriteLine(secondWord + " - " + times2);

							if (times1 > times3)
							{
								writeStream.WriteLine(firstWord + " - " + times1);
								writeStream.WriteLine(thirdWord + " - " + times3);
							}
							else
							{
								writeStream.WriteLine(thirdWord + " - " + times3);
								writeStream.WriteLine(firstWord + " - " + times1);
							}
						}

						else
						{
							writeStream.WriteLine(firstWord + " - " + times1);
							writeStream.WriteLine(secondWord + " - " + times2);
							writeStream.WriteLine(thirdWord + " - " + times3);
						}
					}
				}
			}
		}
	}
}