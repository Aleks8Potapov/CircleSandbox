﻿using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace AppForTests
{
    public class Helper
    {
        public static string RemoveDiacriticsRegExp(string text)
        {
            return new Regex(@"\p{Mn}", RegexOptions.Compiled).Replace(text.Normalize(NormalizationForm.FormD), string.Empty);
        }
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString.EnumerateRunes())
            {
                var unicodeCategory = Rune.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}