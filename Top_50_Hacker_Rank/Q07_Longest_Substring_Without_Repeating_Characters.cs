/*

Problem: Given a string, find the length of the longest substring without repeating characters.
Description: Use a sliding window with two pointers, where one pointer tracks the start of the window and the other pointer moves through the string to identify substrings.
Difficulty: Medium
Example: "abcabcbb" → Longest substring length is 3 ("abc")

 
HashSet provides O(1) average time complexity for Contains(), Add(), and Remove() operations
Dictionary would also provide O(1), but HashSet is simpler since we only need to track existence

HashSet only stores the unique elements
Dictionary would require storing both key and value, which is unnecessary here since we only need to track character presence

We use a sliding window approach with two pointers (left and right)
The HashSet stores characters in our current window
When we encounter a duplicate:

We remove characters from the left until we remove the duplicate
This effectively shrinks our window from the left


For each valid window:

We add the new character
Update maxLen if current window is longer
 
 */

using System.ComponentModel.DataAnnotations;

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q07_Longest_Substring_Without_Repeating_Characters
    {

        public int LengthOfLongestNonRepeatSubstring(string s)
        {
            int left = 0, maxLen = 0;

            var seen = new HashSet<char>();

            for(int right = 0; right < s.Length; right++)
            {
                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[right]);
                    left++;
                }
                seen.Add(s[right]);
                maxLen= Math.Max(maxLen, right - left + 1);
            }

            return maxLen;
            
        }

        public string LongestNonRepeatedSubString(string s)
        {
            int left =0,maxLen = 0;
            int bestLeft = 0; //track the starting position of the best substring
            var seen = new HashSet<char>();


            for(int right=0;right < s.Length; right++)
            {
                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }
                seen.Add(s[right]);


                //if we found a larger substring , update both length and starting position 

                if(right - left +1 > maxLen)
                {
                    maxLen = right - left + 1;  
                    bestLeft = left;
                }
            }
            // Return the substring using the stored position and length
            return s.Substring(bestLeft, maxLen);

        }
    }
}
