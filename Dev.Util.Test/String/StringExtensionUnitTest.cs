using Dev.Util.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev.Util.Test.String
{
    [TestClass]
    public class StringExtensionUnitTest
    {
        [TestMethod]
        public void WhenTheParameterIsAnAlphanumericStringThenShouldReturnOnlyNumbers()
        {
            Assert.AreEqual("234", StringExtension.OnlyNumberDigits("!234Qwer"));
        }
    }
}
