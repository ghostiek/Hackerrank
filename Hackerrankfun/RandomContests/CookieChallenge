using System;
class Solution
{

    // https://www.hackerrank.com/contests/w22/challenges/cookie-party

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        // Guests
        int n = Convert.ToInt32(tokens_n[0]);
        // Cookies made
        int m = Convert.ToInt32(tokens_n[1]);

        int min = 0;
        //Everyone needs to have the same amount
        while (m % n != 0)
        {
            ++min;
            ++m;
        }
        Console.WriteLine(min);
    }
}
