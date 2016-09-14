using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
class Solution
{
    // https://www.hackerrank.com/contests/projecteuler/challenges/euler022
    static void Main(String[] args)
    {
        // # of test cases
        int n = Convert.ToInt32(Console.ReadLine());
        //Array for each word
        string[] l = new string[n];
        int i = 0;
        while (n > 0)
        {
            // Adds every word to the array
            l[i] = Console.ReadLine();
            --n;
            ++i;            
        }
        // Sorts array in alphabetical order
        Array.Sort(l);
        
        // New loop
        int num = Convert.ToInt32(Console.ReadLine());
        while (num > 0)
        {
            string name = Console.ReadLine();
            //Finds name's position (and adds 1 to compensate for index starting at 0)
            int position = Array.IndexOf(l, name) + 1;
            //Makes string into array to add up all the values
            char[] arr = name.ToCharArray();
            int solution = 0;
            //Goes through each char and gives it its value
            foreach(char c in arr)
            {
                //Adds up everything to final value. We add 1 because 'A' is 1 not 0. Its also cleaner and makes more sense than
                //to pick the ascii before 'A'
                solution += c - 'A' + 1;
            }
            solution *= position;
            Console.WriteLine(solution);
            --num;
        }
    }
}
