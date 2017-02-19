using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
//https://www.hackerrank.com/contests/w24/challenges/apple-and-orange

    static void Main(String[] args)
    {
        //Distance of house
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        //Positions of trees
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        //# of m apples and n oranges
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        //Distance each apple falls from tree a
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
        //Distance each orange falls from tree b
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

        var sol_apple = apple.Where(x => x >= s - a && x <= t - a).ToArray();
        var sol_orange = orange.Where(x => x <= t - b && x >= s - b).ToArray();

        Console.WriteLine(sol_apple.Length);
        Console.WriteLine(sol_orange.Length);
    }
}
