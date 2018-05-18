using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dev.Util.String
{
     public static class StringExtension
    {
      
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
