using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q8_PerfectNumber
    {
        //Perfect Number: Sum of its proper divisors equals the number. Ex: 28 [1+2+4+7+14=28]
        public bool IsPerfectNumber(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum++;
            }
            return sum == num;
        }
    }
}
