namespace SomeClasses
{
    using System.Collections.Generic;
    public class VerySimpleMath
    {

        public int Add(int a, int b)
        {
            int res = a + b;
            return res;
        }

        public int Subtract(int a,int b)
        {

            return a - b;
        }

        public int AddNums(IList<int> vals)
        {
            int sum=0;
            foreach (int n in vals)
                sum += n;
            return sum;
        }
    }
}
