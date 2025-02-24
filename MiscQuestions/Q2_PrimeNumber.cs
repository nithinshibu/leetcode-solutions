using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q2_PrimeNumber
    {
        /*Prime Number: A number that has exactly two factors (1 and itself).*/

        public bool IsPrimeNumber(int num)
        {
            if(num <=1) return false;
            if(num==2) return true;
            if(num%2==0) return false;
            

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if(num%i==0) return false;
            }
            return true;

        }
    }
}

/*Why loop till  Math.Sqrt(num)
             
                ---The Logic---

                Factor Pairs: 
                If a number n is composite (not prime), it must have at least one factor pair (two numbers that multiply together to give n).

                One Factor Must Be Smaller:
                In any factor pair (a, b) that produces n (a * b = n), at least one of the factors (either 'a' or 'b') must be less than or equal to the square root of n.

                If both factors were greater than the square root of n, their product would be greater than n.
                Finding a Factor: Therefore, if we don't find any factors of n up to its square root, then n must be prime.
                
                Example

                Let's take the number 36:

                Its square root is 6.
                Factor pairs of 36 are:
                1 x 36
                2 x 18
                3 x 12
                4 x 9
                6 x 6
                Notice that at least one number in each factor pair is less than or equal to 6.
             
             
*/
