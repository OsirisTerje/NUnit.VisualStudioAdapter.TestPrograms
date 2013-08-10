using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit.Test
{
    using Xunit;

    [Trait("Category","Async")]
    public class AsyncX
    {
        [Fact]
        public async Task AsyncTestX1()
        {
            Assert.True(true); ;
        }
    }
}
