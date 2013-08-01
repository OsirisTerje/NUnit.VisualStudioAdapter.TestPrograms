
namespace UnitTestProject1
{

    using NUnit.Framework;

    [CI]
    [TestFixture]
    public class NUnitTest10
    {
        [Test]
        public void TestMethodN11()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestMethodN12()
        {
            var sut = new SomeClasses.VerySimpleMath();
            int result = sut.Add(2, 3);
            Assert.AreEqual(result, 5);
        }
    }


}
