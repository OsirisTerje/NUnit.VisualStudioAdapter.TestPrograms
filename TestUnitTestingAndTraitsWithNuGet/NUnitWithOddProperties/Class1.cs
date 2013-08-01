using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitWithOddProperties
{
   
    using NUnit.Framework;

    [TestFixture]
    public class NUnitTestOdd
    {
        [Test]
        [Property("Developer","Terje")]
        public void TestMethodOpn1()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        [Property("Developer", "Jakob")]
        public void TestMethodOpn2()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

    }
}
