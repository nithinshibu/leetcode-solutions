namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q12_HappyNumber
    {
        //Happy Number: Sum of squares of digits eventually reaches 1. Ex: 19
        public bool IsHappyNumber(int number)
        {
            HashSet<int> seen = new HashSet<int>();

            while (number !=1 && !seen.Contains(number))
            {
                seen.Add(number);
                number = number.ToString().Select(digit => (int)Math.Pow(digit - '0',2)).Sum();
            
            }
            return number == 1;
        }
    }
}
