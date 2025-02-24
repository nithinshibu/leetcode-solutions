using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q11_GreatestCommonDivisor
    {
        //Greatest Common Divisor (GCD): Largest number that divides two numbers.
        public int GCD(int a,int b)
        {

            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;

        }
    }
}
