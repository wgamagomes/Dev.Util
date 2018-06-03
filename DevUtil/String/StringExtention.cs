using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace DevUtil.String
{
     public static class StringExtension
    {
        /// <summary>
        /// Replaces all strings that contains multiple spaces in a strings with single space
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToSingleSpace(this string input)
        {
			if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            var pattern = @"\s+"; 

            return Regex.Replace(input, pattern, " ");
        }

        /// <summary>
        /// Extracts numbers from  alphanumeric string 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ExtractNumbers(this string input)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            char[] charArray = input
                .Where(c => Char.IsDigit(c))
                .ToArray();

            return new string(charArray);             
        }

        /// <summary>
        /// Converts the source string to title case, 
        /// except for words that are entirely in uppercase, which are considered to be acronyms.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string input)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input);
        }

    }
}