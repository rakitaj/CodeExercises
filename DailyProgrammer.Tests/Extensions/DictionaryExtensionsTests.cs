using DailyProgrammer.Extensions;
using FluentAssertions;

namespace DailyProgrammer.Tests.Extensions
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void Dict_SetDefault_IfKeyDoesNotExist_Should_Return_DefaultValue()
        {
            var dict = new Dictionary<string, int>();
            var result = dict.SetDefault("foo", 42);
            result.Should().Be(42);
        }

        [Fact]
        public void Dict_SetDefault_IfKeyExists_Should_Return_Value()
        {
            var dict = new Dictionary<string, int> { ["foo"] = 11 };
            var result = dict.SetDefault("foo", 42);
            result.Should().Be(11);
        }
    }
}
