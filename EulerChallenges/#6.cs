using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution
{
//https://www.hackerrank.com/contests/projecteuler/challenges/euler006
    static void Main(String[] args)
    {

        int num = Convert.ToInt32(Console.ReadLine());
        while (num > 0)
        {
            --num;
            var i = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(squareofsum(i) - sumofsquares(i));

        }

    }
    public static long sumofsquares(long i)
    {
        long solution = 0;
        for(long n = i; n>0; --n)
        {
            solution += n * n;
        }

        return solution;
    }

    public static long squareofsum(long i)
    {
        long solution = 0;
        for (long n = i; n > 0; --n)
        {
            solution += n;
        }

        return solution*solution;
    }

}
