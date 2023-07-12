using FluentAssertions;

namespace GildedRose.Tests
{
    public class QualityControlTests
    {
        [Fact]
        public void Test_Change_Quality_When_Positive_Sellby_Should_Be_1()
        {
            var item = new Item("Boring old running shoes.", 2, 10);
            var newQuality = QualityControl.TickQuality(item);
            newQuality.Should().Be(9);
        }

        [Fact]
        public void Test_Change_Quality_When_Zero_Sellby_Should_Be_2()
        {
            var item = new Item("Boring old running shoes.", 0, 10);
            var newQuality = QualityControl.TickQuality(item);
            newQuality.Should().Be(8);
        }

        [Fact]
        public void Test_Quality_Should_Not_Go_Below_0()
        {
            var item = new Item("Boring old running shoes.", 6, 0);
            var newQuality = QualityControl.TickQuality(item);
            newQuality.Should().Be(0);
        }

        [Fact]
        public void Test_Quality_Should_Not_Go_Above_50()
        {
            var item = new Item("Boring old running shoes.", 6, 40);
            var newQuality = QualityControl.TickQuality(item, 20);
            newQuality.Should().Be(50);
        }
    }
}
