using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeClasses;
using NUnit.Framework;

namespace NUnit.test
{
    [TestFixture]
    class MultipleTestsInArraysN
    {
        /// <summary>
        /// Test with an array of test cases, and no naming given, these are then shown as -1- test, but with multiple results
        /// </summary>
        /// <param name="expectedTotal"></param>
        /// <param name="vals"></param>
        [Test]
        [TestCase(5, new int[] { 2, 3 })]
        [TestCase(5, new int[] { 1, 2, 2 })]
        public void WithNoName(int expectedTotal, int[] vals)
        {
            var calc = new VerySimpleMath();
            int total = calc.AddNums(vals);
            Assert.AreEqual(expectedTotal, total);
        }

        /// <summary>
        /// Test with an array of test cases, and naming given as properties, and these are seperated out as seperate test cases
        /// </summary>
        /// <param name="expectedTotal"></param>
        /// <param name="vals"></param>
        [Test]
        [TestCase(5, new int[] { 2, 3 },TestName="Case A")]
        [TestCase(5, new int[] { 1, 2, 2 },TestName="Case B")]
        public void WithName(int expectedTotal, int[] vals)
        {
            var calc = new VerySimpleMath();
            int total = calc.AddNums(vals);
            Assert.AreEqual(expectedTotal, total);
        }
    }
}
