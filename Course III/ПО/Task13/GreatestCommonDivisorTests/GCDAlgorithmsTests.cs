using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreatestCommonDivisor.Tests
{
    [TestClass()]
    public class GCDAlgorithmsTests
    {


        [TestMethod()]
        public void FindGCDEuclidTest_5()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int e = 258;
            int expected = 86;
            int actual = GCDAlgorithms.FindGCDEuclid(a, b, c, d,e);
            Assert.AreEqual(actual, expected);

        }

        [TestMethod()]
        public void FindGCDEuclidTest_4()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int expected = 86;
            int actual = GCDAlgorithms.FindGCDEuclid(a, b, c,d);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void FindGCDEuclidTest_3()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int expected = 86;
            int actual = GCDAlgorithms.FindGCDEuclid (a, b,c);
            Assert.AreEqual(actual, expected);
        }
    }
}