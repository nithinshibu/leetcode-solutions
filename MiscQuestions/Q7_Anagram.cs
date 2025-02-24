using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q7_Anagram
    {
        //Anagram: Words containing the same characters in different orders.

        public bool AreAnagrams(string str1,string str2)
        {
            if (str1.Length != str2.Length) return false;

            string sortedStr1 = new string(str1.ToLower().OrderBy(c => c).ToArray());
            string sortedStr2 = new string(str2.ToLower().OrderBy(c => c).ToArray());

            return sortedStr1 == sortedStr2;
        }
    }
}
