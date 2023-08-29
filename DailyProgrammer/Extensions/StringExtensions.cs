namespace DailyProgrammer.Extensions
{
    public static class StringExtensions
    {
        public static Dictionary<char, int> CharCounts(this string s)
        {
            var charCounts = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if(charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts.Add(c, 1);
                }
            }
            return charCounts;
        }

        public static bool IsAlphaNumeric(this char c)
        {
            int asciiVal = (int)c;
            return (asciiVal >= 48 && asciiVal <= 57) || (asciiVal >= 65 && asciiVal <= 90) || (asciiVal >= 97 && asciiVal <= 122);
        }
    }
}
