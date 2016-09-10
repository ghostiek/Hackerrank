using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
  // https://www.hackerrank.com/contests/hourrank-12/challenges/repeated-string
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());

        char[] arr = s.ToCharArray();

        long number_of_a = 0;
        foreach(char a in arr)
        {
            if(a == 'a')
            {
                ++number_of_a;
            }
        }

        if(number_of_a == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            long mult = n / Convert.ToInt64(s.Length);
            long sol = number_of_a * mult;

            long remainder = n % Convert.ToInt64(s.Length);

            if (remainder == 0)
            {
                Console.WriteLine(sol);
            }
            else
            {
                for (long l = 0; l < remainder; ++l)
                {
                    if (arr[l] == 'a')
                    {
                        ++sol;
                    }
                }
                Console.WriteLine(sol);
            }
        }

    }
}
