using Dev.Util.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dev.Util.Test.Enum
{
    [TestClass]
    public class EnumExtensionUnitTest
    {
        [TestMethod]
        public void WhenTheParameterIsAnEnumWithDescriptionAttributeThenShouldGetTheDescriptionStoredInThisAttribute()
        {   
            Assert.AreEqual("UNDEFINED", EnumExtension.Description(Foo.Undefined));
            Assert.AreEqual("FOO", EnumExtension.Description(Foo.foo));
            Assert.AreEqual("BAR", EnumExtension.Description(Foo.bar));
        }
    }
}

[Flags]
public enum Foo
{
    [System.ComponentModel.Description("UNDEFINED")]
    Undefined = 0,

    [System.ComponentModel.Description("FOO")]
    foo = 1,

    [System.ComponentModel.Description("BAR")]
    bar = 2,
}

[Flags]
public enum Bar
{
    Undefined = 0,

    foo = 1,

    bar = 2,
}
