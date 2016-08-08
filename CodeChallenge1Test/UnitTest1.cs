using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenge1;

namespace CodeChallenge1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var enteredNumbrs = new int[4] { 1, 2, 3,4 };
            var result = CodeChallengeOne.CheckSum(enteredNumbrs);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var enteredNumbrs = new int[4] { 11, 20, 8, 31 };
            var result = CodeChallengeOne.CheckSum(enteredNumbrs);
            Assert.IsTrue(result);
        }
    }
}
