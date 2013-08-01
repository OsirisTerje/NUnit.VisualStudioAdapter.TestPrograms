using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    abstract public class MSUnitTestBase
    {
        [TestMethod]
        public void BaseTestMethod1()
        {
            Assert.IsTrue(true);
        }
    }

    [TestClass]
    public class MSUnitTestDerived : MSUnitTestBase
    {
        [TestMethod]
        public void DerivedTestMethod()
        {
            Assert.IsTrue(true);
        }
    }


}
