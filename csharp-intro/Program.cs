using System;
using System.Text;

namespace csharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var numbers= Console.ReadLine().Split('-');
            var consecutive = true;

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (Convert.ToInt32(numbers[i]) + 1 != Convert.ToInt32(numbers[i + 1]))
                {
                    consecutive = false;
                    break;
                }
            }

            if (consecutive)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");

            //2.
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var nums = Console.ReadLine().Split('-');
            var duplicate = false;
            Array.Sort(nums);

            for (var i = 0; i < nums.Length -1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    duplicate = true;
                    break;
                }
            }

            if (duplicate)
                Console.WriteLine("Duplicate");

            //3.
            Console.Write("Enter a valid time format (e.g. 19:00): ");
            var time = Console.ReadLine().Split(':');
            var hours = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);

            if (hours < 00 || hours > 24)
                Console.WriteLine("Invalid");
            else if (minutes < 00 || minutes > 59)
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Ok");

            //4.
            Console.Write("Enter a few words seperated by a space: ");
            var words = Console.ReadLine().Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                for (var j = 0; j < words[i].Length; j++)
                {
                    if (j == 0)
                        Console.Write(words[i][j].ToString().ToUpper());
                    else
                        Console.Write(words[i][j].ToString().ToLower());
                }
            }
            Console.WriteLine();

            //5.
            Console.Write("Enter an English word: ");
            var word = Console.ReadLine();
            var vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            var count = 0;

            foreach(var letter in word)
            {
                for (var i = 0; i < vowels.Length; i++)
                {
                    if (letter == vowels[i])
                        count++;
                }
            }

            Console.WriteLine(count);
                
        }
    }
}
