using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using System.Collections.Generic;
    using System.Diagnostics;

    [TestClass]
    public class MSUnitTest1
    {
       
        [TestProperty("Runningtime","Short")]
        [Priority(2)]
        [WorkItem(12)]
        [Owner("Terje")]
        [TestCategory("CI")]
        [TestMethod]
        public void TestMethodMs1()
        {
            Debug.WriteLine("MsTest1");
            Trace.WriteLine("MSTest TestMethodMs1 started");
            Console.WriteLine("MSTest1 started");
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Thread.Sleep(2000);
            Assert.AreEqual(result, 5);
            Trace.WriteLine("MSTest TestMethodMs1 ended");
            Console.WriteLine("MSTest1 ended");
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Developer")]
        public void TestMethodMs2()
        {
            Trace.WriteLine("MSTest TestMethodMs2 started");
            var sut = new SomeClasses.VerySimpleMath();
            for (int i = -100; i < 100; i++)
            {
                int result = sut.Add(i, i * 2);
                Assert.AreEqual(result, i + (i * 2));
            }
            Thread.Sleep(2000);
            Trace.WriteLine("MSTest TestMethodMs2 ended");
            //Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Production")]
        public void TestMethodMs3()
        {
            Trace.WriteLine("MSTest TestMethodMs3 started");
            var numbers = new List<int> { -1, -2, -3, -4, 0, 1, 2, 3, 4, 5, 6, 7 };
            var sut = new SomeClasses.VerySimpleMath();
            var random = new Random();
            Thread.Sleep(3000);
            foreach (int x in numbers)
            {
                int y = random.Next(0, 1000);
                int result = sut.Add(x, y);
                Assert.AreEqual(result, x + y);
            }
            Trace.WriteLine("MSTest TestMethodMs3 ended");
           
        }

        [TestCategory("New")]
        [TestMethod]
        public void TestMethodMs6()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        [Ignore]
        [TestCategory("CI")]
        public void TestMethodMs4()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Ignore]
        [TestCategory("CI")]
        public void TestMethodMs5()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestAddInNet4()
        {
            var uut = new SomeClasses4.VerySimpleMath4();
            int result = uut.Add(4, 5);
            Assert.AreEqual(9,result);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestMethodMSOutput1()
        {
            Console.WriteLine("Testing Console.Write");
            Debug.WriteLine("Testing Debug.Write");
            Trace.WriteLine("Testing Trace.Write");
            throw new Exception("Test aborted intentionally");
        }

        [TestMethod]
        public void TestMethodMSOutput2()
        {
            Debug.WriteLine("Testing Debug.Write");
            Console.WriteLine("Testing Console.Write");
            Debug.WriteLine("Testing Debug.Write");
            Console.WriteLine("Testing Console.Write");
            Trace.WriteLine("Testing Trace.Write");
        }

    }
}
