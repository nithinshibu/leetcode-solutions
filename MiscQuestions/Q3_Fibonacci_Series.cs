using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q3_Fibonacci_Series
    {
        //Fibonacci Series: Each number is the sum of the two preceding ones.

        public static List<int> FibonacciSeries(int n)
        {
            List<int> fib = new List<int>();

            int a = 0, b = 1;
            for(int i = 0; i < n; i++)
            {
                fib.Add(a);
                b = a + b;
                a = b - a;
            }
            return fib;
        }
    }
}


/*
 
With using the temp also we can achieve this result

fib.Add(a);
int temp = a;
a = b;
b = temp + b;
 
 */