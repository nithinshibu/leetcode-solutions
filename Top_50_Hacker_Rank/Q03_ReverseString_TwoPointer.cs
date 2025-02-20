using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q03_ReverseString_TwoPointer
    {
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            //two-pointer
            int left = 0;
            int right = charArray.Length - 1;


            //swap characters from both ends until the pointers meet the middle
            while(left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                //move the pointers 

                left++;
                right--;
            }

            return new string(charArray);

        }

    }
}

/*
 *Time Complexity: O(n), where n is the length of the string.
 *Space Complexity: O(n), as we convert the string to a character array.
 *
 * 
 */
