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
            var path = @"C:\Projects\Csharp-Intro\HelloWorld\HelloWorld.sln";

            Console.WriteLine("Extension Path: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }

    }
}
