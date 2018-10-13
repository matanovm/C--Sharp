using System;
using System.IO;

namespace _04.Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string CopyFile = @"D:\GitHub_Repository\C--Sharp\Streams\04. Copy Binary File\image.jpg";
            using (var sourceFile = new FileStream(CopyFile , FileMode.Open))
            {
                string NewFile = @"D:\GitHub_Repository\C--Sharp\Streams\04. Copy Binary File\copiedimage.jpg";
                using (var destinacionFile = new FileStream(NewFile , FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        var readBytesCount = sourceFile.Read(buffer, 0, buffer.Length);
                        if (readBytesCount == 0)
                            break;

                        destinacionFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}