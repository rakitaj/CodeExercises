using DailyProgrammer.LeetCode.ArrayQuestions;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.Tests.Leetcode
{
    public class ArrayQuestionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] {1, 2 }, 2)]
        public void Test_RemoveDuplicates(int[] nums, int[] expectedArray, int expectedK)
        {
            var solution = new RemoveDuplicatesSolution();
            var k = solution.RemoveDuplicates(nums);
            k.Should().Be(expectedK);
            for(var i = 0; i < expectedK; i++)
            {
                nums[i].Should().Be(expectedArray[i]);
            }
        }
    }
}
