using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.LeetCode.StringQuestions
{
    public class FindStrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            for(int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                var ii = i;
                var j = 0;
                while (haystack[ii] == needle[j])
                {
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                    ii += 1;
                    j += 1;
                }
            }
            return -1;
        }
    }
}
