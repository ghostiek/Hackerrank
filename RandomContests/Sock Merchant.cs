using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
//https://www.hackerrank.com/contests/world-codesprint-7/challenges/sock-merchant
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        int solution = 0;
        List<int> alreadycounted = new List<int>();
        foreach(int num in c)
        {
            if (!alreadycounted.Contains(num))
            {
                solution += c.Count(x => x == num)/2;
                alreadycounted.Add(num);
            }
        }
        Console.WriteLine(solution);
        }
}
