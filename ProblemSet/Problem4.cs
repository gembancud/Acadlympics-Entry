using System;
using System.Text;

namespace ProblemSet
{
    public class Problem4
    {
        private string AlphaNumChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public string[] Output { get; set; }

        public Problem4(int n)
        {
            if(n>=1000 || n<=0) throw new System.ArgumentOutOfRangeException();
            Random rnd = new Random();
            Output = new string[n];

            for (int i = 0; i < n; i++)
            {
                StringBuilder temp = new StringBuilder(12);
                for (int j = 0; j < 12; j++) temp.Append(AlphaNumChars[rnd.Next(0, AlphaNumChars.Length)]);
                Output[i] = temp.ToString();
            }
        }
    }
}