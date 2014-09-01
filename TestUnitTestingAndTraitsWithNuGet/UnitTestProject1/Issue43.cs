using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



// Tests for Issue #43
namespace MultiTest
{
    [TestFixture(typeof(int))]
    public class GenericTests<T>
    {
        [Test]
        public void GenericTest1()
        { }

        [Test]
        public void GenericTest2()
        { }
    }


    [TestFixture]
    public class NonGenericTests
    {
        [Test]
        public void NonGenericTest1()
        { }

        [Test]
        public void NonGenericTest2()
        { }
    }


}
