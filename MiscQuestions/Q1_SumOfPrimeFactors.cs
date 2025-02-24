using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q1_SumOfPrimeFactors
    {

        public int SumOfPrimeFactors(int number)
        {
            int sum = 0;
            //check for the number of 2s in the factorization
            while(number % 2 == 0)
            {
                sum += 2;
                number /= 2;
            }

            //check for odd factors from 3 onwards
            for(int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    sum += i;
                    number /= i;
                }
            }

            //If number is still greater than 2 , then it is prime.
            if(number > 2)
            {
                sum += number;
            }

            return sum;
        }
    }
}
