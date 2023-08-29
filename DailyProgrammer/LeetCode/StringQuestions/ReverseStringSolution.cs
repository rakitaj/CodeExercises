namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            var half = s.Length / 2;
            for(int i = 0; i < half; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
