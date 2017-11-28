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
            //1.
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();
                if (name == "")
                    break;
                names.Add(name);
            }

            var count = names.Count();
            if (count == 0)
                Console.WriteLine();
            else if (count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else if (count == 2)
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            else
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], count - 2);

            //2.
            var nameString = "";
            do
            {
                Console.Write("Enter your name: ");
                nameString = Console.ReadLine();
            }
            while (nameString == "");

            var length = nameString.Length;
            var nameArray = new char[length];
            for (var i = 0; i < length; i++)
                nameArray[i] = nameString[i];

            Array.Reverse(nameArray);
            Console.WriteLine(nameArray);

            //3. 
            var numbers = new List<int>();

            while (numbers.Count() < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.IndexOf(number) != -1)
                    Console.WriteLine("Number already added try again.");
                else
                    numbers.Add(number);
            }
            numbers.Sort();

            foreach (var n in numbers)
                Console.Write("{0},", n);

            Console.WriteLine();

            //4.
            var nums = new List<int>();

            while (true)
            {
                Console.Write("Enter another number or 'Quit': ");
                var input = Console.ReadLine();
                if (input == "Quit")
                    break;
                else
                    nums.Add(Convert.ToInt32(input));
            }

            foreach (var num in nums)
            {
                if (nums.LastIndexOf(num) != -1)
                    continue;
                else
                    Console.WriteLine(num);
            }

            //5.
            var n = "";
            var numArray = new int[5];
            var index = 0;

            while (true)
            {
                Console.Write("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
                n = Console.ReadLine();
                if (n.Length < 13)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                else
                    break;
            }

            foreach (var num in n)
            {
                if (num == ',' || num == ' ')
                    continue;
                else
                    numArray[index] = (int) Char.GetNumericValue(num);
                index++;
            }

            Array.Sort(numArray);
            Console.WriteLine("{0}, {1}, {2}", numArray[0], numArray[1], numArray[2]);
        }
    }
}
