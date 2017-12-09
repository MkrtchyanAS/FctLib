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

            long actual = obj.Fact(5);

            Assert.AreEqual(120, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            FactClass obj = new FactClass();

            long actual = obj.Fact(3);

            Assert.AreEqual(6, actual);

        }

        [TestMethod]
        public void TestMethod20()
        {
            FactClass obj = new FactClass();

            long actual = obj.Fact(20);

            Assert.AreEqual(2432902008176640000, actual);

        }
    }
}
