namespace DailyProgrammer.Algorithms
{
    public class Permutations
    {
        public static void AllPermutations(string s, int i, List<string> permutations)
        {
            if (i == s.Length)
            {
                permutations.Add(s);
            }
            else
            {
                for (int j = i; j < s.Length; j++)
                {
                    var swappedString = Swap(s, i, j);
                    AllPermutations(swappedString, i + 1, permutations);
                }
            }
        }

        public static string Swap(string s, int i, int j)
        {
            char[] chars = s.ToCharArray();
            var tempChar = chars[i];
            chars[i] = chars[j];
            chars[j] = tempChar;
            return new string(chars);
        }
    }
}
