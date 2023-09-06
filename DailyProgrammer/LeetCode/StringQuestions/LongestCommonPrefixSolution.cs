namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 2)
            {
                return strs.FirstOrDefault() ?? string.Empty;
            }
            string lcp = "";
            foreach (var c in strs.First())
            {
                foreach (var str in strs)
                {
                    if (!str.StartsWith(lcp + c))
                    {
                        return lcp;
                    }
                }
                lcp = lcp + c;
            }
            return lcp;
        }
    }
}
