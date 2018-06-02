using System.ComponentModel;
using System;

namespace DevUtil.Test.Enum.Dummies
{
    [Flags]
    public enum Foo
    {
        [Description("UNDEFINED")]
        Undefined = 0,

        [Description("FOO")]
        foo = 1,

        [Description("BAR")]
        bar = 2,
    }

    [Flags]
    public enum Bar
    {
        Undefined = 0,

        foo = 1,

        bar = 2,
    }
}
