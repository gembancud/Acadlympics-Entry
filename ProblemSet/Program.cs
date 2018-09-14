using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1 sample1 = new Problem1("abcba");
            Console.WriteLine(sample1.IsPalindrome);

            Problem2 sample2 = new Problem2(1000000000);
            Console.WriteLine(sample2.Sum);

            Problem3 sample3 = new Problem3(18446744073709551615);
            Console.WriteLine(sample3.Sum);

            Problem4 sample4 = new Problem4(50);
            foreach (string s in sample4.Output)
            {
                Console.WriteLine(s);
            }

            Problem5 sample5 = new Problem5(10000);
            Console.WriteLine(sample5.Sum);

            Console.ReadLine();
        }
    }
}
