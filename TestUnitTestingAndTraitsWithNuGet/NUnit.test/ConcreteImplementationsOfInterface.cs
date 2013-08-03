using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.test
{
    /// <summary>
    /// Earlier known as your BaseTests class
    /// </summary>
    [TestFixture]
    public class TestOfConcreteImplementationsOfInterface
    {
        [TestCaseSource("CreateConcretes")]
        [Test]
        public void VerifyImplementations(IWhatever thing)
        {
            int input = 42;
            int result = thing.DoSomething(input);
            Assert.That(result, Is.EqualTo(input));
        }

        /// <summary>
        /// Factory method for the concrete classes.  If you want this in a seperate class, you can do that too using the 
        /// ctor public TestCaseSourceAttribute(Type sourceType, string sourceName);
        /// </summary>
        public IEnumerable<IWhatever> CreateConcretes
        {
            get
            {
                yield return new A();
                yield return new B();
            }
        }
    }
    
    public interface IWhatever
    {
        int DoSomething(int x);
    }

    public class A : IWhatever
    {
        public int DoSomething(int x)
        {
            return x;
        }
    }

    public class B : IWhatever
    {

        public int DoSomething(int x)
        {
            return x;
        }
    }
}
