using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace _07._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            var filesDictionary = new Dictionary<string, List<FileInfo>>();
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;

                if (!filesDictionary.ContainsKey(extension))
                {
                    filesDictionary[extension] = new List<FileInfo>();
                }

                filesDictionary[extension].Add(fileInfo);
            }

            filesDictionary = filesDictionary
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string desktop = @"C:\Users\matan\OneDrive\Desktop\";
            string fullFileName = desktop + "report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var pair in filesDictionary)
                {
                    string extension = pair.Key;
                    writer.WriteLine(extension);
                    var fileInfos = pair.Value.
                    OrderByDescending(fi => fi.Length);

                    foreach (var fileInfo in fileInfos)
                    {
                        double filesize = (double)fileInfo.Length / 1024;
                        writer.WriteLine($"-- {fileInfo.Name} - {filesize:f3}kb");
                    }
                }
            }
        }
    }
}
