using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.test
{
    [TestFixture]
    public class Issue34
    {

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void TestOutput(string s)
        {
            Console.WriteLine(s);
            Trace.WriteLine(s);
            Assert.IsTrue(true);
        }
    }
}
