//https://www.hackerrank.com/challenges/countingsort4/problem
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrankkms
{
    class Solution
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            var input = Read(length);
            var orderedInput = CustomSort(input);

            var treshhold = length / 2 - 1;

            var solution = orderedInput.Select(x => x.OriginalIndex > treshhold ? x.Str : "-");

            Console.WriteLine(string.Join(" ", solution));

        }

        public static List<Input> Read(int length)
        {

            var input = new List<Input>();
            for (int i = 0; i < length; ++i)
            {
                var row = Console.ReadLine().Split(' ');
                input.Add(new Input(i, int.Parse(row[0]), row[1]));
            }

            return input;
        }

        public static IEnumerable<Input> CustomSort(List<Input> input)
        {
            var result = input.OrderBy(x => x.Digit).ThenBy(y => y.OriginalIndex);

            //var solution = result.Select(x => x.Str);

            return result;
        }
    }

    class Input
    {
        public int OriginalIndex { get; set; }
        public int Digit { get; set; }
        public string Str { get; set; }
        public Input(int originalIndex, int digit, string str)
        {
            OriginalIndex = originalIndex;
            Digit = digit;
            Str = str;
        }
    }
}
