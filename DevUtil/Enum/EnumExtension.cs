using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DevUtil.Enum
{
    public static class EnumExtension
    {
        public static string Description<TEnum>(this TEnum input)
        {
            if (input == null)
                throw new ArgumentNullException($"An instance of type {nameof(TEnum)} can't be null.");

            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException($"The current type of {nameof(TEnum)} should be an enumeration.");


            FieldInfo fieldInfo = typeof(TEnum).GetField(input.ToString());

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes == null || attributes.Length == 0)
                throw new ArgumentException($"The argument {nameof(input)} of type {typeof(TEnum).FullName} doesn't have a Description decorator attribute set.");

            return attributes[0].Description;

        }
        
        public static TEnum Parse<TEnum>(this object input, bool getDefault = false)
        {
            if (input == null)
            {
                if (getDefault)
                    return default(TEnum);

                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");
            }

            return (TEnum)System.Enum.Parse(typeof(TEnum), input.ToString());
        }

        public static IEnumerable<TEnum> FlagsToCollection<TEnum>(this TEnum input)
        {
            return input
                    .ToString()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(f => f.Parse<TEnum>());
        }
    }
}
