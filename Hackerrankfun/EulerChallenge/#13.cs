using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
class Solution
{
//https://www.hackerrank.com/contests/projecteuler/challenges/euler013
    static void Main(String[] args)
    {
        BigInteger a = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 0)
        {
            --n;
            a += BigInteger.Parse(Console.ReadLine());
        }
        Console.WriteLine(a.ToString().Substring(0, 10));
        
    }
}
