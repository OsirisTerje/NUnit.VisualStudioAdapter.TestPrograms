using System;
using System.IO;


namespace UnitTestProjectX1
{
    using System.Diagnostics;
    using System.Threading;

    using Xunit;


    public class XUnitTest1
    {
        [Fact]
        [Trait("Category", "CI")]
        [Trait("Parallell"," ")]
        public void TestMethodBX1()
        {
            Debug.WriteLine("XUnitTest TestMethodBX1 started");
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
            Thread.Sleep(200);
            Trace.WriteLine("XUnitTest TestMethodBX1 started");
            
        }

        [Fact]
        [Trait("Category", "CI")]
        [Trait("Parallell", " ")]
        public void TestMethodBX2()
        {
            Trace.WriteLine("XUnitTest TestMethodBX2 started");
            
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
            Thread.Sleep(200);
            
            Trace.WriteLine("XUnitTest TestMethodBX2 started");
            
        }

        [Fact]
        [Trait("Category", "Developer")]
        [Trait("Runningtime", "Short")]
        [Trait("Priority", "2")]
        [Trait("Owner", "Terje")]
        public void TestMethodBX3()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

        [Fact]
        [Trait("Priority","2")]
        [Trait("Category","CI")]
        public void TestMethodBX4()
        {
            Assert.True(true);
        }
        
        
        [Fact]
        public void TestMethodXOutput()
        {
            Console.WriteLine("Testing Console.Write");
            Debug.WriteLine("Testing Debug.Write");
            Trace.WriteLine("Testing Trace.Write");
            throw new Exception("Test aborted intentionally");
        }

}

    //public class CategoryAttribute : TraitAttribute
    //{
    //    public CategoryAttribute(string value) : base("Category",value)
    //    {}
    //}

    //public class CIAttribute : CategoryAttribute
    //{
    //    public CIAttribute() : base("CI")
    //    {}
    //}

    //public class Priority : TraitAttribute
    //{
    //    public Priority(int value) : base("Priority",value.ToString())
    //    {}
    //}
}
