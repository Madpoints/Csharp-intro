using csharp_intro.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "John";
            var lastName = "F.";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Jill" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(fullName);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look at the following paths
C:\folder1
C:\folder2";
            Console.WriteLine(text);
        }
    }
}
