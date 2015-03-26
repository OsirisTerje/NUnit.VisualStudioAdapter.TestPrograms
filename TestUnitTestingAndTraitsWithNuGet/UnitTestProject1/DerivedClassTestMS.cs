using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DerivedClassTestMS
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
