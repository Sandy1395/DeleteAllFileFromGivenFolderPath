
using System;
using System.IO;

namespace DeleteAllFileFromGivenFolderPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\commercient Folder\Commercient Information\FileRecord";

            DeleteFilesOlderThanOneMonth(path);

            Console.WriteLine("Files deleted.");
        }
        static void DeleteFilesOlderThanOneMonth(string path)
        {
            DateTime threshold = DateTime.Now.AddMonths(-1);

            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.LastWriteTime < threshold)
                {
                    file.Delete();
                }
            }
        }
    }
}
