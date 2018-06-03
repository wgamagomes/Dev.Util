using DevUtil.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevUtil.Test.String
{
    [TestClass]
    public class EncodeToBase64Test
    {
        [TestMethod]
        public void WhenTheSourceStringIsNotEmptyAndEncodingIsNotProvidedThenABase64ShoulBedReturned()
        {
            string input = "La Casa De Papel";
            Assert.AreEqual("TGEgQ2FzYSBEZSBQYXBlbA==", input.EncodeToBase64());
        }

        [TestMethod]
        public void WhenTheSourceStringIsNotEmptyAndUTF8EncodingIsProvidedThenABase64ShoulBedReturned()
        {
            string input = "àáãèéìíòóùúÀÁÃÈÉÌÍÒÓÙÚ";
            Assert.AreEqual("w6DDocOjw6jDqcOsw63DssOzw7nDusOAw4HDg8OIw4nDjMONw5LDk8OZw5o=", input.EncodeToBase64(Encoding.UTF8));
        }
        
        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.EncodeToBase64());
        }
    }
}
