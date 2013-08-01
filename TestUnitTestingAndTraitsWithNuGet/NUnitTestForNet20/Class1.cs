namespace NUnitTestForNet20
{
    using NUnit.Framework;

    using SomeClasses;

    [TestFixture]
    public class NUnit20TestingSimpleMath20
    {
        [Test]
        [Property("Priority",2)]
        public void TestAddNet20()
        {
            var x = new VerySimpleMath();
            Assert.AreEqual(5,x.Add(2,3));
        }

        
    }
}
