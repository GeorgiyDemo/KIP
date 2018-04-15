using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileEditor;
using System.IO;

namespace Lab5UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TextFileOperationsTest and is intended
    ///to contain all TextFileOperationsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TextFileOperationsTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        // TODO - Complete Unit Tests

        /// <summary>
        ///A test for readTextFileContents
        ///</summary>
        [TestMethod()]
        public void ReadTextFileContentsTest1()
        {
            string fileName = @"..\..\..\CommandsTest.txt";
            string expected = "Move(9.23,78)\r\nRotate(65.3)\r\nWait(10)\r\nMove(1,1)\r\n";
            string actual = null;
            //actual = FileEditor.TextFileOperations.ReadTextFileContents(fileName);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for writeTextFileContents
        ///</summary>
        [TestMethod()]
        public void WriteTextFileContentsTest1()
        {
            string fileName = @"..\..\..\WriteTest.txt";
            string text = "This is a test file\r\nWith some simple content\r\n";
            //FileEditor.TextFileOperations.WriteTextFileContents(fileName, text);
            string expected = File.ReadAllText(fileName);
            Assert.AreEqual(expected, text);
            File.Delete(fileName);
        }
    }
}
