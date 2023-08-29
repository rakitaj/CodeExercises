using DailyProgrammer.Algorithms;
using FluentAssertions;

namespace DailyProgrammer.Tests
{
    public class PermutationsTests
    {
        [Fact]
        public void Test_Permutations_Empty_String()
        {
            var s = "";
            var permutations = new List<string>();
            Permutations.AllPermutations(s, 0, permutations);
            permutations.Should().BeEquivalentTo(new List<string>() { "" });
        }

        [Fact]
        public void Test_Permutations_One_Char_String()
        {
            var s = "a";
            var permutations = new List<string>();
            Permutations.AllPermutations(s, 0, permutations);
            permutations.Should().BeEquivalentTo(new List<string>() { "a" });
        }

        [Fact]
        public void Test_Permutations_Two_Char_String()
        {
            var s = "ab";
            var permutations = new List<string>();
            Permutations.AllPermutations(s, 0, permutations);
            permutations.Should().BeEquivalentTo(new List<string>() { "ab", "ba" });
        }

        [Fact]
        public void Test_Permutations_Three_Char_String()
        {
            var s = "abc";
            var permutations = new List<string>();
            Permutations.AllPermutations(s, 0, permutations);
            permutations.Should().BeEquivalentTo(new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" });
        }
    }
}
