using System;
using System.Collections.Generic;

namespace ProblemSet
{
    public class Problem2
    {
        public ulong Sum { get; set; }

        public Problem2(int input)
        {
            ulong SumOfIntegersInFibonacci = 1;
            int limit = input;
            int prevValue = 0;
            int CurrentFibonacciNumber = 1;
            while (true)
            {
                int temp = CurrentFibonacciNumber;
                CurrentFibonacciNumber = prevValue + CurrentFibonacciNumber;
                prevValue = temp;
                if (CurrentFibonacciNumber > limit) break;

                SumOfIntegersInFibonacci += (ulong)CurrentFibonacciNumber;
            }

            Sum =SumOfIntegersInFibonacci;
        }
    }
}