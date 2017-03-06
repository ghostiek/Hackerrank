using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
//Note this program works, its just slow
//https://www.hackerrank.com/contests/hourrank-18/
    static void Main(String[] args)
    {
        string s = Console.ReadLine();


        //Step 1 get all possible values
        List<string> Values = ListOfAllPossibleValues(s);
        //Step 2 Eliminate all the ones with leading 0s
        List<string> SanitizedValues = SanitizeList(Values);
        //Step 3 Figure out which of them are divisible by 6
        List<int> SolutionList = DivisibleBy6(SanitizedValues);
        //Step 4 Print Solution
        //Only to check values
        //Print(SolutionList);

        //Actual Solution
        Console.WriteLine(SolutionList.Count);

    }

    public static List<string> ListOfAllPossibleValues(string s)
    {
        List<string> StrList = new List<string>();
        for(int i = 0; i < s.Length; ++i)
        {
            for(int l = i; l < s.Length; ++l)
            {
                StrList.Add(s.Substring(i, s.Length-l));
            }
        }

        return StrList;
    }

    public static List<string> SanitizeList(List<string> str)
    {

        str.RemoveAll(x => x.StartsWith("0") && x.Length > 1);
        return str;
    }

    public static List<int> DivisibleBy6(List<string> str)
    {
        var IntList = str.Select(int.Parse).ToList();
        IntList.RemoveAll(x => x%6 != 0);
        return IntList;
    }

    public static void Print(List<int> IntList)
    {
        foreach (var item in IntList)
        {
            Console.WriteLine(item);
        }
    }
}
