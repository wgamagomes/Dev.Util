using DevUtil.Enum;
using DevUtil.Test.Enum.Dummies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevUtil.Test.Enum
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void WhenTheSourceIsAByteThatCanBeParsedThenThecorrespondingEnumerationShouldBeReturned()
        {
            Byte? input = 1;
            Assert.AreEqual(Foo.foo, input.Parse<Foo>());
        }

        [TestMethod]
        public void WhenTheSourceIsAnIntegerThatCanBeParsedThenThecorrespondingEnumerationShouldBeReturned()
        {
            int input = 2;
            Assert.AreEqual(Foo.bar, input.Parse<Foo>());
        }

        [TestMethod]
        public void WhenTheSourceIsAStringThatCanBeParsedThenThecorrespondingEnumerationShouldBeReturned()
        {
            string input = "0";
            Assert.AreEqual(Foo.Undefined, input.Parse<Foo>());
        }
                
        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenADefaultValueShouldBeReturned()
        {
            int? input = null;
            Assert.AreEqual(Foo.Undefined, input.Parse<Foo>(true));            
        }

        [TestMethod]
        public void WhenTheSourceIsANullInstanceThenAnArgumentNullExceptionShouldBeThrown()
        {
            int? input = null;
            Assert.ThrowsException<ArgumentNullException>(() => input.Parse<Foo>());
        }

        [TestMethod]
        public void WhenTheSourceIsNotAnEnumerationThenAnArgumentExceptionShouldBeThrown()
        {
            string input = string.Empty;
            Assert.ThrowsException<ArgumentException>(() => input.Parse<Foo>());
        }
    }
}

