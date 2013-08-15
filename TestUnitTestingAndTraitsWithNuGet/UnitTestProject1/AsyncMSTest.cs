using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MultiTest
{
    [TestClass]
    public class AsyncMS
    {
        [TestCategory("Async")]
        [TestMethod]
        public async Task AsyncTestMS1()
        {
            Assert.IsTrue(true);
        }
    }
}
