using DailyProgrammer.LeetCode.StringQuestions;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.Tests.Leetcode
{
    
    public class StringQuestionTests
    {
        [Theory]
        [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o'}, new char[] {'o', 'l', 'l', 'e', 'h'})]
        [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        public void Test_ReverseString(char[] s, char[] expected)
        {
            var solution = new ReverseStringSolution();
            solution.ReverseString(s);
            s.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("aabb", -1)]
        public void Test_FirstUniqueCharacter(string s, int expected)
        {
            var solution = new FirstUniqueCharacterSolution();
            var actualIndex = solution.FirstUniqChar(s);
            actualIndex.Should().Be(expected);
        }

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void Test_IsAnagram(string s, string t, bool expected)
        {
            var solution = new ValidAnagramSolution();
            var actual = solution.IsAnagram(s, t);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData(".,", true)]
        [InlineData("a.", true)]
        public void Test_IsPalindrome(string s, bool expected)
        {
            var solution = new IsPalindromeSolution();
            var actual = solution.IsPalindrome(s);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("9", 9)]
        [InlineData("-2", -2)]
        [InlineData("10", 10)]
        [InlineData("+10", 10)]
        [InlineData("-10", -10)]
        [InlineData("1923412", 1923412)]
        [InlineData("-1923412", -1923412)]
        [InlineData("4193 with words", 4193)]
        [InlineData("-91283472332", Int32.MinValue)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData("20000000000000000000", Int32.MaxValue)]
        [InlineData("+-12", 0)]
        [InlineData("9223372036854775808", 2147483647)]
        [InlineData("   +0 123", 0)]
        public void Test_MyAToI(string s, int expected)
        {
            var solution = new StringToIntegerSolution();
            var actual = solution.MyAtoi(s);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("a", "a", 0)]
        public void Test_StrStr(string haystack, string needle, int expected)
        {
            var solution = new FindStrSolution();
            var actual = solution.StrStr(haystack, needle);
            actual.Should().Be(expected);
        }
    }
}
