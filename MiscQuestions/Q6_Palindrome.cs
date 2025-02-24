using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q6_Palindrome
    {
        public bool IsPalindrome(string str)
        {
            str=str.ToLower();
            int left = 0;
            int right = str.Length - 1;

            while(left < right)
            {
                if (str[left] != str[right]) return false;

                left++;
                right--;

            }
            return true;
        }
    }
}
