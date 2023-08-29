using DailyProgrammer.Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.Challenges
{
    public class Challenge400
    {
        public static bool PracticalNumber(int n)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }
            for (int i = 1; i < n; i++)
            {

            }
            throw new NotImplementedException();
        }

        public static HashSet<int> SumToN(int n, List<int> divisors)
        {
            var smallerThanN = divisors.Where(x => x < n).ToList();
            List<BitArray> allPermutations = new List<BitArray>();
            throw new NotImplementedException();
        }

        public static List<int[]> AllPermutations(int n)
        {
            var permutations = new List<int[]>();
            for(int i = 0; i < Math.Pow(2, n); i++)
            {
                var bits = ByteConversions.FromInteger(i);
                permutations.Add(bits);
            }
            return permutations;
        }
    }
}
