//using System;

//namespace UnitTestProjectMb
//{
//    using System.Collections.Generic;
//    using MbUnit.Framework;

    
//    [TestFixture]
//    public class MbUnitTest1
//    {

//        // [Importance(Importance.Serious)] 
//        [Author("Terje")]
//        [Test]
//        [Category("CI")]
//        public void TestMethodMb1()
//        {
//            var sut = new SomeClasses.VerySimpleMath();
//            int result = sut.Add(2, 3);
//            Assert.AreEqual(result, 5);
//        }

//        [Test]
//        [Category("Developer")]
//        public void TestMethodMb2()
//        {
//            var sut = new SomeClasses.VerySimpleMath();
//            for (int i = -100; i < 100; i++)
//            {
//                int result = sut.Add(i, i * 2);
//                Assert.AreEqual(result, i + (i * 2));
//            }
//            //Assert.Fail();
//        }

//        [Test]
//        [Category("Production")]
//        public void TestMethodMb3()
//        {
//            var numbers = new List<int> { -1, -2, -3, -4, 0, 1, 2, 3, 4, 5, 6, 7 };
//            var sut = new SomeClasses.VerySimpleMath();
//            var random = new Random();
//            foreach (int x in numbers)
//            {
//                int y = random.Next(0, 1000);
//                int result = sut.Add(x, y);
//                Assert.AreEqual(result, x + y);
//            }
//        }
//    }

//    [CI]
//    [TestFixture]
//    public class MbUnitTest10
//    {
//        [Test]
//        public void TestMethodMb11()
//        {
//            var sut = new SomeClasses.VerySimpleMath();
//            int result = sut.Add(2, 3);
//            Assert.AreEqual(result, 5);
//        }

//        [Test]
//        public void TestMethodMb12()
//        {
//            var sut = new SomeClasses.VerySimpleMath();
//            int result = sut.Add(2, 3);
//            Assert.AreEqual(result, 5);
//        }
//    }

//    public class CIAttribute : CategoryAttribute
//    {
//        public CIAttribute() : base("CI")
//        {
            
//        }
//    }

//}
