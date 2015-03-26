using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace xUnit.Test
{
    
    public class ParametrizedXUnitTest
    {

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        public void XTestParamInt(int a)
        {
            Assert.True(true);
            
        }
    }
}
