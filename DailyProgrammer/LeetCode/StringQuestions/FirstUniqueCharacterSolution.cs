namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class FirstUniqueCharacterSolution
    {
        public int FirstUniqChar(string s)
        {
            var charsIndex = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                var seenIndex = charsIndex.ContainsKey(c) ? int.MaxValue : i;
                charsIndex[c] = seenIndex;
            }

            var minSeen = charsIndex.MinBy(kvp => kvp.Value).Value;
            if (minSeen == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return minSeen;
            }
        }
    }
}
