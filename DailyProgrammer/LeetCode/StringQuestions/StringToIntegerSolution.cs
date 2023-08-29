namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class StringToIntegerSolution
    {
        public int MyAtoi(string s)
        {
            Int32 total = 0;
            var sign = 1;
            var operatorSeen = false;

            for (var i = 0;i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '+' || s[i] == '-')
                {
                    if (operatorSeen)
                    {
                        return total;
                    }
                    if (s[i] == '+')
                    {
                        operatorSeen = true;
                        continue;
                    }
                    if (s[i] == '-')
                    {
                        operatorSeen = true;
                        sign = -1;
                        continue;
                    }
                    continue;
                }

                var n = CToI(s[i]);
                if (n == -1)
                {
                    break;
                }
                if (sign == 1 && total > (Int32.MaxValue - n) / 10)
                {
                    return Int32.MaxValue;
                }
                if (sign == -1 && total < (Int32.MinValue + n) / 10)
                {
                    return Int32.MinValue;
                }
                total = total * 10 + sign * n;
                operatorSeen = true;
            }

            return total;
        }

        public int CToI(char c)
        {
            var asciiValue = (int)c;
            if (asciiValue >= 48 && asciiValue <= 57)
            {
                return asciiValue - 48;
            }
            return -1;
        }
    }
}
