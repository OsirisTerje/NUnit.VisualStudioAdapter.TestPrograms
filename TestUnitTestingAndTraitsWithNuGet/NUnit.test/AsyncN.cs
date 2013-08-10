using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.test
{
    using NUnit.Framework;

    [Category("Async")]
    [TestFixture]
    public class AsyncN
    {
        [Test]
        public async Task AsyncTestN1()
        {
            Assert.Pass();
        }
    }
}
