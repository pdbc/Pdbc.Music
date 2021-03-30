using System;
using System.Linq;

namespace Pdbc.Music.UnitTest.Helpers.Extensions
{
    public class UnitTestValueGenerator
    {
        private static readonly Random Random = new Random();

        public const string Alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string Numeric = "1234567890";
        public static string Characters = $"{Alphanumeric}{Numeric}";

        public static string GenerateText(int length, string possibleCharacters = null)
        {
            if (possibleCharacters == null)
            {
                possibleCharacters = Characters;
            }

            var code = new string(Enumerable.Repeat(possibleCharacters, length).Select(s => s[Random.Next(s.Length)]).ToArray());
            return code;
        }


        public static long GenerateRandomNumber(int length = 6)
        {
            return long.Parse(GenerateText(length, Numeric));
        }
        public static string GenerateRandomCode(int length = 16)
        {
            return GenerateText(length, Characters);
        }
    }
}