using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Dev.Util.Enum
{
    public static class EnumExtension
    {
        /// <summary>
        ///  Gets the description stored in the DescriptionAttribute of enumeration.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Description<TEnum>(this TEnum value)
        {
            if (value == null)
                throw new ArgumentNullException($"An instance of type {nameof(TEnum)} can't be null.");

            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException($"The current type of {nameof(TEnum)} should be an enumeration.");


            FieldInfo fieldInfo = typeof(TEnum).GetField(value.ToString());

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes == null || attributes.Length == 0)
                throw new ArgumentException($"The argument {nameof(value)} of type {typeof(TEnum).FullName} doesn't have a Description decorator attribute set.");

            return attributes[0].Description;

        }

        /// <summary>
        /// Converts an object into one or more  enumerated constants.       
        /// If the passed value is null and getDefault was set to true then the default value of the enumerated
        /// is returned, if not an ArgumentNullException is thrown.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value">The value to convert to enumerated constant.</param>
        /// <param name="getDefault">Indicates whether to get the default enumerated constant.</param>
        /// <returns></returns>
        public static TEnum Parse<TEnum>(this object value, bool getDefault = false)
        {
            if (value == null)
            {
                if (getDefault)
                    return default(TEnum);

                throw new ArgumentNullException($"The parameter {nameof(value)} can't be null.");
            }

            return (TEnum)System.Enum.Parse(typeof(TEnum), value.ToString());
        }

        public static IEnumerable<TEnum> FlagsToCollection<TEnum>(this TEnum flags)
        {
            return flags
                    .ToString()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(f => f.Parse<TEnum>());
        }
    }
}
