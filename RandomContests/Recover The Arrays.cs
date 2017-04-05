using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
//https://www.hackerrank.com/contests/hourrank-19/challenges/recover-the-array
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] file_temp = Console.ReadLine().Split(' ');
        int[] file = Array.ConvertAll(file_temp, Int32.Parse);
        //  Print the number of arrays defined in 'file' to STDOUT.

        long solution = 0;
        for(int i = 0; i < file.Length; ++i)
        {
            var e = file[i];
            i += e;
            ++solution;
        }
        Console.WriteLine(solution);
    }
}
