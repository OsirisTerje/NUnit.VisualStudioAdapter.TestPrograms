using System;
using NUnit.Framework;

namespace NUnitTestForNet20
{
    [TestFixture]
    public class Issue_Uri
    {
        [Test]
        public void UriWithStringTest()
        {
            const string urlWithDots = "http://host.com/path./";

            var uriString = new Uri(urlWithDots).ToString();

            Assert.AreEqual(urlWithDots, uriString);


        }


        [Test]
        public void UriWithUriTest()
        {
            const string urlWithDots = "http://host.com/path./";
            
            Assert.AreEqual(urlWithDots, new Uri(urlWithDots).ToString());


        }

    }
}
