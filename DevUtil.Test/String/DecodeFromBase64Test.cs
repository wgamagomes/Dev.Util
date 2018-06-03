using DevUtil.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevUtil.Test.String
{
    [TestClass]
    public class DecodeFromBase64Test
    {
        [TestMethod]
        public void WhenTheSourceStringIsABase64AndEncodingIsNotProvidedThenAStringDecodedShouldBeReturned()
        {
            string base64 = "TGEgQ2FzYSBEZSBQYXBlbA==";
            Assert.AreEqual("La Casa De Papel", base64.DecodeFromBase64());
        }

        [TestMethod]
        public void WhenTheSourceStringIsABase64AndUTF8EncodingIsProvidedThenAStringDecodedShouldBeReturned()
        {
            string base64 = "w6DDocOjw6jDqcOsw63DssOzw7nDusOAw4HDg8OIw4nDjMONw5LDk8OZw5o=";
            Assert.AreEqual("àáãèéìíòóùúÀÁÃÈÉÌÍÒÓÙÚ", base64.DecodeFromBase64(Encoding.UTF8));
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.ToSingleSpace());
        }
    }
}
