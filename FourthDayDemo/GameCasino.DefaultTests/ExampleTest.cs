using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameCasino.DefaultTests
{
    [TestClass]
    public class ExampleTest
    {
        bool isInitialized = false;

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMethod1()
        {
            throw new NullReferenceException();
            Assert.AreEqual(1,  1);
       } 

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 2,"One should be equal to two");
        }

        [TestInitialize]
        public void BeforeAllTests()
        {
            this.isInitialized = true;
        }

        [TestCleanup]
        public void AfterAllTests()
        {
            this.isInitialized = false;
        }
    }
}
