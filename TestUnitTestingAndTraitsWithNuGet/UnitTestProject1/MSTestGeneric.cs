using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    
    [TestClass]
    public abstract class MSTestGeneric<T>  where T : class, new()
    {
        [TestMethod]
        public void TestCreate()
        {
            var v = new T();
            Assert.IsNotNull(v);
        }
    }


    [TestClass]
    public class MSDocumentTest : MSTestGeneric<Document>
    {
        [TestMethod]
        public void NameTest()
        {
            const string Name = "A good one";
            var v = new Document(Name);
            Assert.AreEqual(v.Name,Name);
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
