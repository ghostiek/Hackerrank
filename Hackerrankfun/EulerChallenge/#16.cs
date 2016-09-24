using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution
{
//https://www.hackerrank.com/contests/projecteuler/challenges/euler016
    static void Main(String[] args)
    {

        int num = Convert.ToInt32(Console.ReadLine());
        while (num > 0)
        {
            --num;
            int BigNumber = Convert.ToInt32(Console.ReadLine());
            BigInteger powernumber = BigInteger.Pow(2, BigNumber);
            var arr = powernumber.ToString().ToCharArray();

            BigInteger solution = 0;
            foreach(var q in arr)
            {
                solution += (q - '0');
            }
            Console.WriteLine(solution);
        }
    }
}
