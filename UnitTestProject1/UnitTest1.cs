using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int number01 = 5;
            int number02 = 10;
            int expected = 13;
            //act

            var actual = Sum(5,10);

            //assert
            Assert.AreEqual(expected, actual);

            int Sum(int a ,int b) { 
            
                return a + b;
            }
        }
    }
}
