using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            Assert.AreEqual(i, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int i = 2;
            Assert.AreEqual(i, 111);
        }
    }
}
