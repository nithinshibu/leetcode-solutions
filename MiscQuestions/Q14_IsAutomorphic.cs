using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q14_IsAutomorphic
    {
        //Automorphic Number: Square ends with the number itself.
        public bool IsAutomorphic(int number)
        {
            long square = (long)number * number;
            string numStr = number.ToString();
            string squareStr = square.ToString();
            return squareStr.EndsWith(numStr);
        }
    }
}
