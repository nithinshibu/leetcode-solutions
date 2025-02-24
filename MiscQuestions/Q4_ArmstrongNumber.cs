namespace LeetCodeSolutions.MiscQuestions
{
    internal class Q4_ArmstrongNumber
    {
        //Armstrong Number: Sum of its digits raised to the power of number of digits equals the number itself. Ex=153
        public bool IsArmStrong(int number)
        {
            int original = number;
            int sum = 0;
            int digits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                sum+= (int) Math.Pow(digit,digits);
                number = number / 10;
            }
            return sum == original;
        }
    }
}
