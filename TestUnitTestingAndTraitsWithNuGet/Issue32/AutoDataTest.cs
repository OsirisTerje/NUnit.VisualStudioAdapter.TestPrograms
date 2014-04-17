using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.NUnit2;

namespace Issue32
{

    public interface I
    { }

    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(new Fixture().Customize(new AutoMoqCustomization()))
        { }
    }


    [TestFixture]
    public class TestClass
    {
        [Theory, AutoMoqData]
        public void TestI(I i)
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(true);
        }
    }
}
