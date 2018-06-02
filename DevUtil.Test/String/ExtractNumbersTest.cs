using DevUtil.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevUtil.Test.String
{
    [TestClass]
    public class ExtractNumbersTest
    {
        [TestMethod]
        public void WhenTheSourceStringContainsNumbersThenOnlyNumbersShouldBeReturnedAsOutput()
        {
            Assert.AreEqual("234678", StringExtension.ExtractNumbers("!234Qwer%678Tyui"));
        }

        [TestMethod]
        public void WhenTheSourceStringDoesNotContainNumbersThenAStringEmptyShouldBeReturnedAsOutput()
        {
            Assert.AreEqual(string.Empty, StringExtension.ExtractNumbers("La Casa De Papel"));
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;         
            Assert.ThrowsException<ArgumentNullException>(() => StringExtension.ExtractNumbers(input));
        } 
    }
}
