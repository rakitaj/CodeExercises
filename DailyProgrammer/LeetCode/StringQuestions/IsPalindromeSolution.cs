using DailyProgrammer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class IsPalindromeSolution
    {
        /// <summary>
        /// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all 
        /// non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
        /// </summary>
        /// <param name="s">String checked for being a palindrome.</param>
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                if (!s[start].IsAlphaNumeric())
                {
                    start = start + 1;
                    continue;
                }
                if (!s[end].IsAlphaNumeric())
                {
                    end = end - 1;
                    continue;
                }
                if (s[start] != s[end])
                {
                    return false;
                }
                start = start + 1;
                end = end - 1;
            }
            return true;
        }
    }
}
