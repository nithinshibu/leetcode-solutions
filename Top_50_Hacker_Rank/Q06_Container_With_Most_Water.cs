/*
 
 Container With Most Water (Arrays)
Problem: Given an array representing heights, find the container that can hold the most water. The container's height is determined by the shorter of the two boundary elements.
Description: Use two pointers, one at the beginning and one at the end, and calculate the area between them, adjusting the pointers based on which boundary is shorter.
Difficulty: Medium
Example: [1,8,6,2,5,4,8,3,7] → Maximum water container area is 49.
 
 
 */

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q06_Container_With_Most_Water
    {

        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxArea = 0;

            while(left < right)
            {
                //width is the distance between the two lines (right index - left index)
                int width = right - left;
                //minHeight is the shorter of the two lines (water will spill over the shorter line)
                int minHeight = Math.Min(height[left], height[right]);
                //Area is calculated as width × height, and maxArea is updated if current area is larger
                maxArea = Math.Max(maxArea, width*minHeight);

                if (height[left] < height[right]) left++; else right--;
            }

            return maxArea;
        }
    }
}
