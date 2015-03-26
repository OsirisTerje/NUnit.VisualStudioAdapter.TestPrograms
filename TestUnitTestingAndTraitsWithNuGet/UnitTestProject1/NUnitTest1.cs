
namespace UnitTestProject1
{
    using NUnit.Framework;
    
    namespace NUnitTests
    {
        using System;
        using System.Diagnostics;

        [TestFixture]
        public class NUnitTest1
        {
            /// <summary>
            /// Change the expected to != 5 and verify manually that you get output from the debug and trace statements
            /// </summary>
            [Test]
            [Category("CI")]
            [Property("Priority", "2")]
            [Property("Owner", "Terje")]
            [Property("Runningtime", "Short")]
            public void TestMethodN1()
            {
                int expected = 5;
                Debug.WriteLine("NUnit debug writeline");
                Trace.WriteLine("NUnit trace writeline");
                Console.WriteLine("NUnit console writeline");
                var sut = new SomeClasses.VerySimpleMath();
                int result = sut.Add(2, 3);
                Assert.AreEqual(result, expected);
            }

            /// <summary>
            /// Some comment from VS 2012
            /// </summary>
            [Test]
            [CI]
            [Property("Priority", "1")]
            public void TestMethodN2()
            {
                var sut = new SomeClasses.VerySimpleMath();
                int result = sut.Add(2, 3);
                Assert.AreEqual(result, 5);
            }

            /// <summary>
            /// Second test
            /// </summary>
            [Test]
            [Priority(1)]
            public void TestMethodN3()
            {
                var sut = new SomeClasses.VerySimpleMath();
                int result = sut.Add(2, 3);
                Assert.AreEqual(result, 5);
            }
        }
    }

    public class CI : CategoryAttribute
    { }

    public class PriorityAttribute : PropertyAttribute
    {
        public PriorityAttribute(int value)
            : base("Priority", value)
        {

        }
    }
}
