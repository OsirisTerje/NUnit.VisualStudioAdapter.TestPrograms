using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForNet2
{
    using SomeClasses;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomeClasses2_Add()
        {
            var x = new VerySimpleMath();
            Assert.AreEqual(5,x.Add(2,3));

        }
    }
}
