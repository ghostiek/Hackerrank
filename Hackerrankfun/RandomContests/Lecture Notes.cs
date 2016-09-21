using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution
{
//https://www.hackerrank.com/contests/101hack41/challenges/lecture-notes
    static void Main(String[] args)
    {
        //Number of students | Number of friends of alex
        var n = Console.ReadLine().Split(' ');

        //Binary string 1 = slept | 0 = didn't
        var binary = Console.ReadLine().ToCharArray();

        //IDs of friends
        var id = Console.ReadLine().Split(' ');

        int[] awake = binary.Select((b, i) => b == '0' ? i : -1).Where(i => i != -1).ToArray();

        if(awake.Any(x => id.Contains((x+1).ToString())))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
