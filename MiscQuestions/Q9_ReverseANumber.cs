using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q9_ReverseANumber
    {
        public int ReverseNumber(int num)
        {
            int reversed = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reversed = (reversed * 10) + digit;
                num /= 10;
            }
            return reversed;
        }
    }
}
