namespace UnitTestProjectX1
{

    using Xunit;


    public class XUnitTest1
    {
        [Fact]
        [Trait("Category", "CI")]
        public void TestMethodX1()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

        [Fact]
        [Trait("Category", "CI")]
        public void TestMethodX2()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

        [Fact]
        [Trait("Runningtime", "Short")]
        [Trait("Priority", "2")]
        [Trait("Owner", "Terje")]
        [Trait("Category","Developer")]
        public void TestMethodX3()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3); 
            Assert.Equal(result, 5);
        }

        [Fact]
        [Trait("Category","Production")]
        public void TestMethodX4()
        {
            Assert.True(true);
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
