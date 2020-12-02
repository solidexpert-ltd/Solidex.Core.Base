using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Solidex.Core.Base.Translate
{
    public static class TranslateToLatin
    {
        public static string Translate(this string str)
        {
            var dictionary = new Dictionary<char, string>()
            {
                {Char.Parse("а"), "a" },
                {Char.Parse("б"), "b" },
                {Char.Parse("в"), "v" },
                {Char.Parse("г"), "g" },
                {Char.Parse("д"), "d" },
                {Char.Parse("е"), "e" },
                {Char.Parse("ё"), "e" },
                {Char.Parse("ж"), "zh" },
                {Char.Parse("з"), "z" },
                {Char.Parse("и"), "i" },
                {Char.Parse("й"), "y" },
                {Char.Parse("к"), "k" },
                {Char.Parse("л"), "l" },
                {Char.Parse("м"), "m" },
                {Char.Parse("н"), "n" },
                {Char.Parse("о"), "o" },
                {Char.Parse("п"), "p" },
                {Char.Parse("р"), "r" },
                {Char.Parse("с"), "s" },
                {Char.Parse("т"), "t" },
                {Char.Parse("у"), "u" },
                {Char.Parse("ф"), "f" },
                {Char.Parse("х"), "ch" },
                {Char.Parse("ц"), "ts" },
                {Char.Parse("ч"), "ch" },
                {Char.Parse("ш"), "sh" },
                {Char.Parse("щ"), "sch" },
                {Char.Parse("ы"), "y" },
                {Char.Parse("э"), "e" },
                {Char.Parse("ю"), "u" },
                {Char.Parse("я"), "ia" },
                {Char.Parse("ь"), "" },
                {Char.Parse("ъ"), "" },
                {Char.Parse("-"), "-"}
            };

            var reg = new Regex(@"[^a-zа-я0-9\ ]");

            var f = reg.Replace(str.ToLower(), "");

            f = f.Trim().Replace(" ", "-");

            StringBuilder sb = new StringBuilder();

            foreach (char c in f)
            {
                if (dictionary.ContainsKey(c))
                {
                    sb.Append(dictionary[c]);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}