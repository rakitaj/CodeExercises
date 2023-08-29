using DailyProgrammer.Algorithms;
using FluentAssertions;
using System.Collections;

namespace DailyProgrammer.Tests
{
    public class ByteConversionsTests
    {
        [Theory]
        [InlineData(0, new int[] { 0 })]
        [InlineData(1, new int[] { 1 })]
        [InlineData(2, new int[] { 1, 0 })]
        [InlineData(3, new int[] { 1, 1 })]
        [InlineData(4, new int[] { 1, 0, 0 })]
        [InlineData(104, new int[] { 1, 1, 0, 1, 0, 0, 0 })]
        public void Test_Integer32_To_Bits(int integer, int[] expected)
        {
            var bitArray = ByteConversions.FromInteger(integer);
            bitArray.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(0, 8, new int[] { 0, 0, 0, 0, 0, 0, 0, 0 })]
        [InlineData(1, 8,  new int[] { 0, 0, 0, 0, 0, 0, 0, 1 })]
        [InlineData(2, 8,  new int[] { 0, 0, 0, 0, 0, 0, 1, 0 })]
        [InlineData(3, 8,  new int[] { 0, 0, 0, 0, 0, 0, 1, 1 })]
        [InlineData(4, 8,  new int[] { 0, 0, 0, 0, 0, 1, 0, 0 })]
        [InlineData(104, 8, new int[] { 0, 1, 1, 0, 1, 0, 0, 0 })]
        [InlineData(255, 8, new int[] { 1, 1, 1, 1, 1, 1, 1, 1})]
        public void Test_Integer32_To_Bits_Padded(int integer, int length, int[] expected)
        {
            var bitArray = ByteConversions.FromInteger(integer, length);
            bitArray.Should().BeEquivalentTo(expected);
        }
    }
}