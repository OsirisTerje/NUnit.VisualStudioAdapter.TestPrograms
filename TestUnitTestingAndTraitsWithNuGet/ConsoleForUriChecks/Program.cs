using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForUriChecks
{
    class Program
    {
        static void Main(string[] args)
        {

            const string urlWithDots = "http://host.com/path./";

            var uriString = new Uri(urlWithDots).ToString();


        }
    }
}
