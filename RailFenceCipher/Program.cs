using System;
using System.Text;

namespace RailFenceCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoded = Encode("WEAREDISCOVEREDFLEEATONCE", 3);
            var decoded = Decode(encoded, 3);

            Console.WriteLine(encoded);
            Console.WriteLine(decoded);
        }

        private static string Encode(string str, int rails)
        {
            var keys = GetKeys(rails, str.Length);
            var stringBuilder = new StringBuilder();
            for (var railIndex = 0; railIndex < rails; railIndex++)
            {
                for (var i = 0; i < keys.Length; i++)
                {
                    if (keys[i] == railIndex)
                    {
                        stringBuilder.Append(str[i]);
                    }
                }
            }

            return stringBuilder.ToString();
        }

        private static string Decode(string str, int rails)
        {
            var keys = GetKeys(rails, str.Length);
            var chars = new char[str.Length];
            var strIndex = 0;
            for (var railIndex = 0; railIndex < rails; railIndex++)
            {
                for (var i = 0; i < keys.Length; i++)
                {
                    if (keys[i] == railIndex)
                    {
                        chars[i] = str[strIndex++];
                    }
                }
            }

            return new string(chars);
        }

        private static int[] GetKeys(int rails, int length)
        {
            const int minRailIndex = 0;
            var maxRailIndex = rails - 1;

            var currentRailIndex = minRailIndex;
            var direction = true;

            var keys = new int[length];
            for (var i = 0; i < length; i++)
            {
                keys[i] = currentRailIndex;

                if (currentRailIndex == minRailIndex)
                {
                    direction = true;
                }
                else if (currentRailIndex == maxRailIndex)
                {
                    direction = false;
                }

                currentRailIndex = direction ? ++currentRailIndex : --currentRailIndex;
            }

            return keys;
        }
    }
}