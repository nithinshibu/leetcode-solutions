using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q5_GetFactorsOfANumber
    {
        public List<int> GetFactors(int number)
        {
            List<int> factors = new List<int>();
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    factors.Add(i);
                }

            }
            return factors;
        }
    }
}
