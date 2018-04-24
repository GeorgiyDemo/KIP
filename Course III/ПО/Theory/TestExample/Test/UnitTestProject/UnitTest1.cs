using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program target = new Program();
            int a = 100;
            int b = 34;
            int expected = 134;
            int actual = target.adder(a, b);
            Assert.AreEqual(actual, expected);
        }
    }
}
