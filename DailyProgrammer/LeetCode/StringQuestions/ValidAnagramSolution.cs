using DailyProgrammer.Extensions;

namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class ValidAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            var sChars = s.CharCounts();
            var tChars = t.CharCounts();
            if (sChars.Count == tChars.Count)
            {
                return sChars.Except(tChars).Count() == 0;
            }
            return false;   
        }
    }
}
