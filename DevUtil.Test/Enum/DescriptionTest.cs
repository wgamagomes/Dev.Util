using DevUtil.Enum;
using DevUtil.Test.Enum.Dummies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevUtil.Test.Enum
{
    [TestClass]
    public class DescriptionTest
    {
        [TestMethod]
        public void WhenTheSourceEnumContainsDescriptionAttributeThenShouldGetTheDescriptionStoredInThisAttribute()
        {
            Assert.AreEqual("UNDEFINED", Foo.Undefined.Description());
            Assert.AreEqual("FOO", Foo.foo.Description());
            Assert.AreEqual("BAR", Foo.bar.Description());
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            int? input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.Description());
        }

        [TestMethod]
        public void WhenTheSourceIsNotAnEnumerationThenAnArgumentExceptionShouldBeThrown()
        {
            string input = string.Empty;
            Assert.ThrowsException<ArgumentException>(() => input.Description());
        }

    }  
}
