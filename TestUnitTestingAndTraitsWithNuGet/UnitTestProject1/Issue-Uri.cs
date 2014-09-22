using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MultiTest
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
