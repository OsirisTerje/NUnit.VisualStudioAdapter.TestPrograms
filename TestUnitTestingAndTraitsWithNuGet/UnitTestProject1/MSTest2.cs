using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;

    [TestClass]
   // [TestCategory("CI")] // Compiler error, attribute not valid here
    public class UnitTest2
    {


        [TestMethod]
        public void TestMethodMs11()
        {
            Trace.WriteLine("MSTest TestMethodMs11 started");
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
            Thread.Sleep(200);
            Trace.WriteLine("MSTest TestMethodMs11 ended");
        }

        [TestMethod]
        public void TestMethodMs12()
        {
            var sut = new SomeClasses.VerySimpleMath();
            for (int i = -100; i < 100; i++)
            {
                int result = sut.Add(i, i * 2);
                Assert.AreEqual(result, i + (i * 2));
            }
            //Assert.Fail();
        }

       
    }
}
