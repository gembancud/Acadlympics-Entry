namespace ProblemSet
{
    public class Problem5
    {
        public int Sum { get; set; }
        public Problem5(int input)
        {
            if(input>10000) throw new System.ArgumentOutOfRangeException();

            for (int i = 1; i < input; i++) if (i % 3 == 0 && i % 7 == 0) Sum += i;
        }
    }
}