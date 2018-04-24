using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]

        public void adderTest()
        {
            Program target = new Program();
            int a = 100;
            int b = 1000;
            int expected = 1100;
            int actual = target.adder(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void subdevidedTest()
        {
            Program target = new Program();
            int a = 500;
            int b = 200;
            int expected = 300;
            int actual = target.subdevided(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void multipyTest()
        {
            Program target = new Program();
            int a = 10;
            int b = 5;
            int expected = 50;
            int actual = target.multipy(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void deleteTest()
        {
            Program target = new Program();
            int a = 8;
            int b = 2;
            int expected = 4;
            double actual = target.delete(a, b);
            Assert.AreEqual(actual, expected);
        }
    }
}