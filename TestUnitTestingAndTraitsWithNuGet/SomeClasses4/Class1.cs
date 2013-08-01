using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace SomeClasses4
{
    public class VerySimpleMath4
    {

        public int Add(int a, int b)
        {
            Contract.Requires(a>b);
            int res = a + b;
            return res;
        }

        public int Subtract(int a, int b)
        {
           return a - b;
        }
    }
}
