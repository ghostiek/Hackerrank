using System;
using System.Collections.Generic;
using System.IO;
//https://www.hackerrank.com/contests/w23/challenges/gears-of-war
//Not a hard problem but a fun one to try out the conditional operator
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0){
            --n;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num%2 == 0) ? "Yes" : "No");  
        }
    }
}
