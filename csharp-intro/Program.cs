using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace csharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            //var files = Directory.GetFiles(@"c:\Users\John\source\repos\csharp-intro", "*.sln*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //    Console.WriteLine(file);
            

            var directories = Directory.GetDirectories(@"c:\Users\John\source\repos\csharp-intro", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
