using System;
using System.Diagnostics;
using NUnit.Framework;

namespace NUnit.test
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        [Category("CI")]
        [Property("Priority","2")]
        [Property("Owner","Terje")]
        [Property("Runningtime","Short")]
        public void TestMethodBN1()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        [CI]
        [Property("Priority", "1")]
        public void TestMethodBN2()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        [CI]
        [Priority(1)]
        public void TestMethodBN3()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        [Category("New")]
        [Priority(1)]
        public void TestMethodBN4()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }


        [Test]
        [Explicit]
        public void TestMethodNOutput()
        {
            Console.WriteLine("Testing Console.Write");
            Debug.WriteLine("Testing Debug.Write");
            Trace.WriteLine("Testing Trace.Write");
            throw new Exception("Test aborted intentionally");
        }
    }

    public class CI : CategoryAttribute
    { }

    public class PriorityAttribute : PropertyAttribute
    {
        public PriorityAttribute(int value) : base("Priority",value)
        {
            
        }
    }
}
