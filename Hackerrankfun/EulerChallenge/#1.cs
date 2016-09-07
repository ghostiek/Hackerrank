using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
// https://www.hackerrank.com/contests/projecteuler/challenges/euler001
// Note discussion was of an immense help to solve this faster
    static void Main(String[] args)
    {
        // Test cases
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 0)
        {
            --n;
            long num = Convert.ToInt64(Console.ReadLine()) - 1;

            //Finding all numbers that are multiples of 3, 5 and 15
            long num_3 = arithmeticprog(3, num);
            long num_5 = arithmeticprog(5, num);
            long num_15 = arithmeticprog(15, num);

            // Prints solution
            Console.WriteLine(num_3 + num_5 - num_15);
        }
    }

  public static long arithmeticprog(long factor, long num)
    {

      return factor*(num/factor * (num/factor + 1))/2;
    }
}
