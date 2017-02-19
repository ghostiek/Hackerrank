using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
//https://www.hackerrank.com/contests/101hack46/challenges/marcs-cakewalk/submissions/code/1300505906
    static void Main(String[] args)
    {
        //The compact solution
        int pos = 0;
        int n = Convert.ToInt32(Console.ReadLine());     
        long solution = (Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse))
            .OrderByDescending(x=>x)
            .Sum(x => x * (long)Math.Pow(2, pos++));
        Console.WriteLine(solution);


        // The easier to understand version

        //int n = Convert.ToInt32(Console.ReadLine());
        //string[] calories_temp = Console.ReadLine().Split(' ');
        //int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
        //calories.OrderByDescending(x => x);

        //int solution = 0;
        //int pos = 0;
        //foreach (var item in calories)
        //{
        //    Console.WriteLine(item);
        //    solution += item * (long)Math.Pow(2, pos);
        //    ++pos;
        //}
        //Console.WriteLine(solution);
    }
}
