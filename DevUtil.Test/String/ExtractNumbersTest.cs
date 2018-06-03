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
            string input = "!234Qwer%678Tyui";
            Assert.AreEqual("234678", input.ExtractNumbers());
        }

        [TestMethod]
        public void WhenTheSourceStringDoesNotContainNumbersThenAStringEmptyShouldBeReturnedAsOutput()
        {
            string input = "La Casa De Papel";
            Assert.AreEqual(string.Empty, input.ExtractNumbers());
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;         
            Assert.ThrowsException<ArgumentNullException>(() => input.ExtractNumbers());
        } 
    }
}
