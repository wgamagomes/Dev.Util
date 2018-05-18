using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dev.Util.Test.Enum
{
    [TestClass]
    class EnumExtensionUnitTest
    {

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
