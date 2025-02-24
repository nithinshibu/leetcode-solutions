using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q13_CountVowelsConsonants
    {

        public (int vowels,int consonants) CountVowelsConsonants(string str)
        {
            str = str.ToLower();
            int vowels = str.Count(c=>"aeiou".Contains(c));
            int consonants = str.Count(c=> char.IsLetter(c) && !"aeiou".Contains(c));
            return (vowels, consonants);
        }
    }
}
