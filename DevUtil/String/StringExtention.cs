using System;
using System.Globalization;
using System.Linq;
using System.Text;
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
        /// <summary>
        /// Encodes the source string to base-64 digits.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string EncodeToBase64(this string input, Encoding encoding = null)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            encoding = encoding ?? Encoding.Default;

            return Convert.ToBase64String(encoding.GetBytes(input));
        }

        /// <summary>
        /// Decodes from a base-64 digits, to an equivalent string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string DecodeFromBase64(this string input, Encoding encoding = null)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            encoding = encoding ?? Encoding.Default;

            return encoding.GetString(Convert.FromBase64String(input));
        }

        /// <summary>
        /// Removes diacritical marks, such as the acute (´) and grave (`)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveDiacriticsMarks(this string input)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            var normalizedString = input.Normalize(NormalizationForm.FormD).ToList();
            var stringBuilder = new StringBuilder();

            normalizedString.ForEach(c =>
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);

                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            });

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static bool IsWhiteSpace(this string input)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            if (input.Length == 0)
                return false;


            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static string ToCamelCase(this string input)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            if (input.Length == 0)
                return input;

            input = input
            .ToLower() //for words that are entirely in uppercase, should not consider as an acronym
            .ToTitleCase()
            .Replace(" ", string.Empty);

            return $"{char.ToLowerInvariant(input[0])}{input.Substring(1)}";
        }

        public static string ToPascalCase(this string input)
        {
            if (input == null)
                throw new ArgumentNullException($"The parameter {nameof(input)} can't be null.");

            return input
                 .ToLower() //for words that are entirely in uppercase, should not consider as an acronym
                 .ToTitleCase()
                 .Replace(" ", string.Empty);
        }

    }
}