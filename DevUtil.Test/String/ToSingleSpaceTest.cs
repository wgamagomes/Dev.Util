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
            string input = "La    Casa  De Papel";
            Assert.AreEqual("La Casa De Papel", input.ToSingleSpace());
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.ToSingleSpace());
        }
    }
}
