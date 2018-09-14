using System;

namespace ProblemSet
{
    public class Problem3
    {
        public int Sum { get; set; }
        public Problem3(ulong input)
        {
            ulong tmp = input;
            ulong sum = 0;

            for (int power = input.ToString().Length-1; power >=0; power--)
            {
                ulong divisor = (ulong)Math.Pow(10, power);
                sum += tmp / divisor;
                tmp %= divisor;
            }

            Sum = (int)sum;
        }
    }
}