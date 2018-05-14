using System;

namespace String.Util
{
     public static class StringExtension
    {
       // Convert Whitespaces to  To Single Space
        public static string ToSingleSpace(this string val)
        {
			if (val == null)
                throw new ArgumentNullException(nameof(val));
			
            return Regex.Replace(val, @"\s+", " ");
        }
		
		public static string OnlyNumberDigits(this string val)
        {
            if (val == null)
                throw new ArgumentNullException(nameof(val));

            return new string(val.Where(Char.IsDigit).ToArray());
        }
    }
}
