/*
 
Pair with Given Sum (Arrays)
Problem: Given a sorted array, find two numbers such that their sum is equal to a given target.
Description: Use two pointers to traverse the array from both ends and adjust the pointers based on the sum.
Difficulty: Easy to Medium
Example: [1, 2, 3, 4, 6] and target = 6 → Pair (1, 5) or (2, 4)
 
 */


using System.ComponentModel.Design;

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q05_PairWithGivenSum
    {
        public int[] FindPairsWithSum(int[] arr , int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
                {
                    return new int[] { arr[left], arr[right] }; 
                }else if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return null;//no pair found
        }
    }
}
