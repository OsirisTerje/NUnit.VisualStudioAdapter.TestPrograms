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
    public class AnyFAttribute : ParameterDataAttribute
    {
        public override IEnumerable GetData(ParameterInfo parameter)
        {
            if (parameter.ParameterType == typeof(int))
            {
                return new[] { 122 };
            }
            else
            {
                return new[] { "a" + new Random().Next() }; //______ONLY CHANGE________!
            }
        }
    }

    public class ClassFail
    {
        [Test]
        public void ShouldBEHAVIOR([AnyF] int a, [AnyF] string b)
        {
            Assert.Fail("FAILED!");
        }
    }
}
