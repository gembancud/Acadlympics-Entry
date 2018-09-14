namespace ProblemSet
{
    public class Problem1
    {
        public bool IsPalindrome { get; set; }
        public Problem1(string input)
        {
            IsPalindrome = isPalindrome(input);
        }

        private bool isPalindrome(string input)
        {
            int j = 1;
            for (int i = 0; i < input.Length/2; i++, j++)
            {
                if (input[i] != input[input.Length-j]) return false;
            }
            return true;
        }

    }
}