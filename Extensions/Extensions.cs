using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Solidex.Core.Base.ComplexTypes;
using Solidex.Core.Base.Enums;
using Solidex.Core.Base.Infrastructure;

namespace Solidex.Core.Base.Extensions
{
    public static class Extension
    {
        public static Money Sum<T>(this IEnumerable<T> iEnumerable, Func<T, Money> selector,
            ICurrencyConverter converter)
        {
            var enumerable = iEnumerable as IList<T> ?? iEnumerable.ToList();

            if (enumerable.Count == 0)
                return new Money(0, Currency.RUB);

            var m = new Money(0, selector(Enumerable.First(enumerable)).Currency);
            selector(enumerable[0]);

            return enumerable.Aggregate(m,
                (current, item) => current + converter.Convert(selector(item), current.Currency));
        }

        public static string Md5(this string input)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.Default.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hash)
                sb.Append(t.ToString("X2"));

            return sb.ToString();
        }


        public static string PHPMd5(this string stringToHash)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] input = Encoding.UTF8.GetBytes(stringToHash);
                byte[] hash = md5.ComputeHash(input);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public static string Sha1(this string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            SHA1 sha = new SHA1CryptoServiceProvider();
            var hash = sha.ComputeHash(bytes);
            var sb = new StringBuilder();
            foreach (var t in hash)
                sb.Append(t.ToString("X2"));

            return sb.ToString();
        }

        public static string AddEventTag(this string input, string tag)
        {
            if (string.IsNullOrEmpty(input))
            {
                input = string.Empty;
            }

            var tags = input.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (tags.Contains(tag)){ return string.Join("||", tags);}

            tags.Add(tag);

            return string.Join("||", tags);
        }

        public static string RemoveEventTag(this string input, string tag)
        {
            if (string.IsNullOrEmpty(input))
            {
                input = string.Empty;
            }

            var tags = input.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (tags.TrueForAll(a => a != tag))
            {
                return String.Join("||", tags);
            }

            tags.Remove(tag);
            return String.Join("||", tags);
        }
    }
}