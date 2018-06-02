using DevUtil.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevUtil.Test.String
{
    [TestClass]
    public class ToSingleSpaceTest
    {
        [TestMethod]
        public void WhenTheSourceStringContainsMultipleSpacesThenAStringWithSingleSpacesShouldBeReturnedAsOutput()
        {
            Assert.AreEqual("La Casa De Papel", StringExtension.ToSingleSpace("La    Casa  De Papel"));
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => StringExtension.ToSingleSpace(input));
        }
    }
}
