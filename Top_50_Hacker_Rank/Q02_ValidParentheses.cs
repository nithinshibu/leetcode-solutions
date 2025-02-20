using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Top_50_Hacker_Rank
{
    internal class Q02_ValidParentheses
    {
        public bool IsValidParentheses(string s)
        {
            Dictionary<char,char> map = new Dictionary<char,char>();
            map.Add(')', '(');
            map.Add(']', '[');
            map.Add('}', '{');

            Stack<char> stack = new Stack<char>();
            foreach (char ch in s.ToCharArray()) 
            {
                if(ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0 || stack.Peek() != map[ch]) return false;
                    else stack.Pop();
                }
            }

            return stack.Count == 0;

        }

    }
}
