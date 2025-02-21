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

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q07_Longest_Substring_Without_Repeating_Characters
    {

        public int LengthOfLongestNonRepeatSubstring(string s)
        {
            //left: Marks the left boundary of our current window
            //maxLen: Keeps track of the longest valid substring length found so far
            int left = 0, maxLen = 0;

            //HashSet is perfect here because it provides O(1) lookup and doesn't allow duplicates
            var seen = new HashSet<char>();

            //Iterates through the string using right as the right boundary of our window.This implements the sliding window technique
            for (int right = 0; right < s.Length; right++)
            {
                /*

                If the current character is already in our HashSet, we need to shrink the window:

                Remove characters from the left side of the window
                Move the left pointer forward
                Continue this until we've removed the duplicate of our current character.

                */

                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }
                seen.Add(s[right]);

                /*

                Calculate the length of current window (right - left + 1)
                Update maxLen if the current window is longer than our previous maximum.

                */
                maxLen = Math.Max(maxLen, right - left + 1);
            }

            return maxLen;
            
        }

        public string LongestNonRepeatedSubString(string s)
        {
            /*

            Initializes three variables:

            left: Current window's left boundary
            maxLen: Length of the longest valid substring
            bestLeft: New variable that stores the starting index of the longest substring found


            */

            int left =0,maxLen = 0;
            int bestLeft = 0; //track the starting position of the best substring

            /*

            Same as before: creates a HashSet for unique characters
            Uses sliding window technique with right pointer


            */

            var seen = new HashSet<char>();

            for(int right=0;right < s.Length; right++)
            {
                /*

                If current character exists in HashSet, shrink window from left
                Add current character to HashSet


                */

                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }
                seen.Add(s[right]);


                //if we found a larger substring , update both length and starting position 

                /*

                Key difference from previous version:

                Instead of using Math.Max, we use an if condition
                When we find a longer substring, we:

                Update maxLen with new length
                Store the left index where this longest substring begins


                */

                if (right - left +1 > maxLen)
                {
                    maxLen = right - left + 1;  
                    bestLeft = left;
                }
            }
            // Return the substring using the stored position and length
            /*

            Returns the actual substring using:

            bestLeft: Starting position of the longest substring
            maxLen: Length of the substring



            For example, with input "abcabcbb":

            First unique substring "abc" (bestLeft = 0, maxLen = 3)
            When we hit second 'a', window shifts
            Final result would be "abc" (the actual substring, not just length 3)


            */
            return s.Substring(bestLeft, maxLen);

        }
    }
}
