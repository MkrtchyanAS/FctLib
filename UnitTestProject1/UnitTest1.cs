using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FctLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FactClass obj = new FactClass();

            int actual = obj.Fact(5);

            Assert.AreEqual(120, actual);

        }
    }
}
