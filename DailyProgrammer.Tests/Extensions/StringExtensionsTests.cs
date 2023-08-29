using DailyProgrammer.Extensions;
using FluentAssertions;

namespace DailyProgrammer.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData('c', true)]
        [InlineData('1', true)]
        [InlineData('0', true)]
        [InlineData('!', false)]
        [InlineData(' ', false)]
        public void Test_Char_IsAlphaNumeric(char c, bool expected)
        {
            var actual = c.IsAlphaNumeric();
            actual.Should().Be(expected);
        }
    }
}
