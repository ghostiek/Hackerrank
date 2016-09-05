using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    //https://www.hackerrank.com/challenges/angry-professor
    static void Main(String[] args)
    {
        // # of test cases
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            // # of students
            int n = Convert.ToInt32(tokens_n[0]);
            // Cancellation treshhold
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            if (k <= a.Count(x => x <= 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
