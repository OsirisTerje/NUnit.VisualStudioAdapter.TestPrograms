using System;
using COLL = System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UTDirectPLM
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class |
                AttributeTargets.Interface | AttributeTargets.Assembly,
                AllowMultiple = true)]
    public class ConsoleActionAttribute  : Attribute, ITestAction
    {
        // the wrong behaviour occurs also if I leave empty the class body.


        private string _Message;

        public ConsoleActionAttribute(string message) { _Message = message; }

        public void BeforeTest(ITest test)
        {
            WriteToConsole("Before", test);
        }

        public void AfterTest(ITest test)
        {
            WriteToConsole("After", test);
        }

        public ActionTargets Targets
        {
            get { return ActionTargets.Test | ActionTargets.Suite; }
        }

        private void WriteToConsole(string eventMessage, ITest details)
        {
            Console.WriteLine("{0} {1}: {2}, from {3}.{4}.",
                eventMessage,
                details.IsSuite ? "Suite" : "Case",
                _Message,
                details.FixtureType != null ? details.FixtureType.Name : "{no fixture}",
                details.Method != null ? details.Method.Name : "{no method}");
        }
    }


    [TestFixture]
    [ConsoleAction("Hello")]
    public class ActionAttributeSampleTests
    {
        [Test]
        public void SimpleTestOne()
        {
            Console.WriteLine("Test One.");
        }

        [Test]
        public void SimpleTestTwo()
        {
            Console.WriteLine("Test Two.");
        }
    }


    [AttributeUsage(AttributeTargets.Interface)]
    public class InterfaceAwareActionAttribute : TestActionAttribute
    {
        private readonly string _Message;

        public InterfaceAwareActionAttribute(string message) { _Message = message; }

        public override void BeforeTest(ITest details)
        {
            IHaveAnAction obj = details.Fixture as IHaveAnAction;
            if (obj != null)
                obj.Message = _Message;
        }

        

        public override ActionTargets Targets
        {
            get { return ActionTargets.Test; }
        }


        
    }

    [InterfaceAwareAction("Hello")]
    public interface IHaveAnAction { string Message { get; set; } }

    [TestFixture]
    public class ActionAttributeSampleTests2 : IHaveAnAction
    {
        [Test]
        public void SimpleTest()
        {
            Console.WriteLine("{0}, World!", Message);
        }

        public string Message { get; set; }
    }
}
