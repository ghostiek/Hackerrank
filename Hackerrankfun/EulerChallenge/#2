using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    // https://www.hackerrank.com/contests/projecteuler/challenges/euler002
    public static long Fibonacci(long n)
    {
	long a = 0;
	long b = 1;
        
	for (long i = 0; i < n; i++)
	{
	    long temp = a;
	    a = b;
	    b = temp + b;
	}
	return a;
    }
    
    static void Main(String[] args) {
        // Test case amount
        int T = Convert.ToInt32(Console.ReadLine());
        while(T > 0){
            // So loop ends
            --T;
            // Test case
            long number = Convert.ToInt64(Console.ReadLine());
            // Final answer
            long sum = 0;
            for(long i = 0; Fibonacci(i) <= number; i+=3){                
                // Checks if even
                if(Fibonacci(i)%2 == 0){
                    sum += Fibonacci(i);
                }
            }
            Console.WriteLine(sum);
        }
    }
    
}
