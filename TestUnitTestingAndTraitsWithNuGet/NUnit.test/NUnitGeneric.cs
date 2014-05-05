using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.test
{
    using NUnit.Framework;
     
    
    public  class NUnitGeneric<T>  where T : class, new()
    {
        [Test]
        public void TestCreate()
        {
            var v = new T();
            Assert.IsNotNull(v);
        }
    }


    [TestFixture]
    public class NDocumentTest : NUnitGeneric<Document>
    {
        [Test]
        public void NameTest()
        {
            const string Name = "A good one";
            var v = new Document(Name);
            Assert.That(v.Name,Is.EqualTo(Name));
        }
    }

    public class Document
    {
        public string Name { get; private set; }

        public Document() : this("Unknown")
        {
        }

        public Document(string name)
        {
            Name = name;
        }
    }

    public class Folder
    {
        
    }
}
