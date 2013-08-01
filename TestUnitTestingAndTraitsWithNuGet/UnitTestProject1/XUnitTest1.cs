namespace UnitTestProjectX1
{

    using Xunit;

    [CI]
    public class XUnitTest11
    {
        [Fact]
        public void TestMethodX11()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

        [Fact]
        public void TestMethodX12()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

    }
}
