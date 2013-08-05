using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.test
{
    [Category("Exp")]
    [Explicit]
    [TestFixture]
    public class NUnitExplicit1
    {
        [Test]
        [Category("CI")]
        [Property("Priority", "2")]
        [Property("Owner", "Terje")]
        [Property("Runningtime", "Short")]
        public void TestMethodEN1()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        [Property("Priority", "1")]
        public void TestMethodEN2()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }
    }

    [TestFixture]
    public class NUnitExplicit2
    {
        [Test]
        [Category("CI")]
        [Property("Priority", "2")]
        [Property("Owner", "Terje")]
        [Property("Runningtime", "Short")]
        public void TestMethodEN21()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        [Explicit]
        [Property("Priority", "1")]
        public void TestMethodEN22()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }
    }

}
