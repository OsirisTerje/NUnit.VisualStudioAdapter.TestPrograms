using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestCategory("Async")]
        [TestMethod]
        public async void AsyncTestMS1()
        {
            Assert.IsTrue(true);
        }
    }
}
