using DevUtil.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevUtil.Test.String
{
    [TestClass]
    public class ToTitleCaseTest
    {
        [TestMethod]
        public void WhenTheSourceStringIsNotInTitleCaseThenAStringConvertedToTitleCaseShouldBeReturned()
        {
            string input = "la casa de papel";
            Assert.AreEqual("La Casa De Papel", input.ToTitleCase());
        }

        [TestMethod]
        public void WhenTheSourceStringIsAnAcronymsThenTheSametringShouldBeReturned()
        {
            string input = "SOLID";
            Assert.AreEqual("SOLID", input.ToTitleCase());
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.ToTitleCase());
        }
    }
}
