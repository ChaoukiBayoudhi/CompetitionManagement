using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompetitionManagement
{
    class VerificationEnter
    {
        public static bool EmptyOrOnlySpace(string value)
        {
            return value.Trim() == string.Empty;
        }
        public static bool IsAlpha(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
            //or
            //return value.All(Char.IsLetter);

        }
        public static bool IsAlphaNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
            //or
            //return value.All(Char.IsLetterOrDigit);

        }
        public static bool IsNumeric(string value)
        {
            Regex regex = new Regex(@"^\d+$");//"\d" will match [0-9] and other digit characters like the Eastern Arabic numerals ٠١٢٣٤٥٦٧٨٩.
            //Use "^[0-9]+$" to restrict matches to just the Arabic numerals 0 - 9.
            return regex.IsMatch(value);
            //or
            //return value.All(Char.IsDigit);
        }
        public static bool IsAlphaNumericOr_(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9_]+$");
            //or
            //return value.All(c => Char.IsLetterOrDigit(c) || c == '_');
        }
    }
}
