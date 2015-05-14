namespace UnitTestProjectX1
{

    using Xunit;

    [Trait("Category", "CI")]
    public class XUnitTest11
    {
        [Fact]
        public void TestMethodBX11()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

        [Fact]
        public void TestMethodBX12()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.Equal(result, 5);
        }

    }
}
