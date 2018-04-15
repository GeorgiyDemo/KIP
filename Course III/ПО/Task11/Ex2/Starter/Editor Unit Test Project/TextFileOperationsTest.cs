using FileEditorXML;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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


        /// <summary>
        ///A test for WriteTextFileContents
        ///</summary>
        [TestMethod()]
        public void WriteTextFileContentsTest1()
        {
            string filename = @"..\..\..\WriteTest.txt";
            string text = "This is a test file\r\nWith some simple content\r\n";
            FileEditorXML.TextFileOperations.WriteTextFileContents(filename, text);
            string expected = File.ReadAllText(filename);
            Assert.AreEqual(expected, text);
            File.Delete(filename);
        }

        /// <summary>
        ///A test for ReadAndFilterTextFileContents
        ///</summary>
        [TestMethod()]
        public void ReadAndFilterTextFileContentsTest()
        {
            // TODO - Complete Unit Tests
            string filename = @"..\..\..\CommandsTest.txt";
            string expected = "Move x, 10\nMove y, 20\nIf x &lt; y Add x, y\nIf x &gt; y &amp; x &lt; 20 Sub X, Y\nStore 30\n";
            string actual = null;
            //actual = FileEditorXML.TextFileOperations.ReadAndFilterTextFileContents(filename);
            StringAssert.Equals(expected, actual);
        }
    }
}
