using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.test
{
    [TestFixture]
    public class TestCasesNUnit
    {
        [Test]
        [TestCase(4)]
        [TestCase(5)]
        public void TestCaseNUnitInt(int a)
        {
            Assert.IsTrue(true);
        }
    }
}
