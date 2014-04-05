using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Issue15
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class AnyAttribute : ParameterDataAttribute
    {
        public override IEnumerable GetData(ParameterInfo parameter)
        {
            if (parameter.ParameterType == typeof(int))
            {
                return new[] { 122 };
            }
            else
            {
                return new[] { "a" };
            }
        }
    }

    public class Class1234
    {
        [Test]
        public void ShouldBehavior([Any] int a, [Any] string b)
        {
            Assert.Fail("FAILED!");
        }
    }
}
