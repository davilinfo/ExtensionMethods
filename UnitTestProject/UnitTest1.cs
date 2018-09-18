using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private UsingActivator _usingActivator;
        private const string UsingActivatorNameValue = "test";

        [TestInitialize]
        public void UnitTest1Setup()
        {
            _usingActivator = new UsingActivator();
        }

        [TestMethod]
        public void TestMethod1()
        {
            _usingActivator.Name = UsingActivatorNameValue;

            Assert.IsTrue(_usingActivator.Name == UsingActivatorNameValue);

        }
    }
}
