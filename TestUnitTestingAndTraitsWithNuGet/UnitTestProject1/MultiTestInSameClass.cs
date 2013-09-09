using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MultiTest
{
    [NUnit.Framework.TestFixture]
    [TestClass]
    public class MultiInSameClass
    {
        [TestMethod]
        public void MethodMS1()
        {
            Assert.IsTrue(true);
        }

        [NUnit.Framework.Test]
        public void MethodN1()
        {
            NUnit.Framework.Assert.IsTrue(true);
        }

    }
}
