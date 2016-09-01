using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
class Solution {
//https://www.hackerrank.com/contests/projecteuler/challenges/euler020
    static void Main(String[] args) {
        //# of iterations
        int n = Convert.ToInt32(Console.ReadLine());
        while(n > 0){
            //Input num
            int num = Convert.ToInt32(Console.ReadLine());
            //Factorial of num
            BigInteger total = Factorial(num);
            BigInteger sum = 0;
            //Finding sum of each num
            while (total > BigInteger.Parse(0.ToString())) {
                sum += total % BigInteger.Parse(10.ToString());
                total /= BigInteger.Parse(10.ToString());
            }     
            Console.WriteLine(sum);  
            --n;
        }
        
        
    }
    
    public static BigInteger Factorial(int n)
    {
    if (n == 0)//The condition that limites the method for calling itself
        return 1;
    return n * Factorial(n - 1);
    }
}
