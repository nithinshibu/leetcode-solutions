using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q15_FindMissingNumber
    {
        //Find missing number in sequence 1 to n.
        //int missing = InterviewProblems.FindMissingNumber(new int[] {1,2,4,5}, 5); // 3
        public int FindMissingNumber(int[] arr,int n)
        {
            int expectedSum = (n * (n + 1)) / 2;
            int actualSum = arr.Sum();
            return expectedSum - actualSum;
        }
    }
}
