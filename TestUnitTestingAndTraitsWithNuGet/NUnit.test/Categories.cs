using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.Categories
{
    [TestFixture]
    public class CategoriesTest
    {

        [Requirement("9999")]
        [Test]
        public void Test1()
        { }

        [Category("CI2")]
        [Category("CI")]
        [Test]
        public void Test2()
        { }

        [CI]
        [Test]
        public void Test3()
        { }

        [CI]
        [Test]
        public void Test4()
        { }


        [Req2("7777")]
        [Req2("8888")]
        [Req("2345")]
        [Req("1234")]
        [Test]
        public void Test5()
        { }


        [RequirementsSet(new[] { "1234", "2345" })]
        [Test]
        public void Test6()
        { }
    }


    public class ReqAttribute : CategoryAttribute
    {

        public ReqAttribute(string s)
            : base(s)
        {

        }

    }

    public class Req2Attribute : CategoryAttribute
    {
        public Req2Attribute(string s)
            : base("Requirement:" + s)
        { }
    }

    public class RequirementAttribute : PropertyAttribute
    {
        public RequirementAttribute(string s)
            : base(s)
        {}
    }

    public class RequirementsSetAttribute : PropertyAttribute
    {
        public RequirementsSetAttribute(string[] array)
        {
            int i = 0;
            foreach (var s in array)
            {
                Properties.Add("Requirement-" + i, s);
                i++;
            }
        }
    }

    public class RequirementSetAttribute : PropertyAttribute
    {
        public RequirementSetAttribute(string[] array)
        {
            foreach (var s in array)
            {
                Properties.Add("Requirement", s);
            }

        }
    }




    public class CIAttribute : CategoryAttribute
    { }

}
