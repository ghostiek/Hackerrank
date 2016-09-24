using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution
{
/*
Note: this is as optimized as I could think of making it. It passed 5/6 test cases only failing to time out. This is very easy in Python
but I'll still submit this as my C# solution because this was still good practice and worth it for learning what TrimStart is.
Additionally, it was interesting to go over ModPow.
*/
    static void Main(String[] args)
    {
        int BigNumber = Convert.ToInt32(Console.ReadLine());
        BigInteger solution = 0;
        BigInteger bigmod = 1000000000000000;
        for (int i = 1; i <= BigNumber; ++i)
        {
            if (i % 10 != 0)
            {
            solution += BigInteger.ModPow(i,i, bigmod)%bigmod;
            }
        }

        if (solution.ToString().Length <= 10)
        {
            Console.WriteLine(solution);
        }
        else
        {
            string string_ = solution.ToString().Substring(solution.ToString().Length - 10, 10);
            Console.WriteLine(string_.TrimStart(new char[] { '0' }));
        }


    }
}
