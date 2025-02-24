namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q10_PerfectSquare
    {
        //Perfect Square: Number that has an integer square root.
        public bool IsPerfectSquare(int number)
        {
            if(number < 0) return false;
            int sqrt = (int) Math.Sqrt(number);
            return sqrt*sqrt ==number;

        }
    }
}
