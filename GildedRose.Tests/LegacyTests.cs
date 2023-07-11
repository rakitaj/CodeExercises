using FluentAssertions;

namespace GildedRose.Tests
{
    public class LegacyTests
    {
        internal static List<Item> CreateItems()
        {
            var items = new List<Item>
                {
                    new Item("+5 Dexterity Vest", 10, 20),
                    new Item("Aged Brie", 2, 0),
                    new Item("Elixir of the Mongoose", 5, 7),
                    new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                    new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                    new Item ("Conjured Mana Cake", 3, 6)
                };
            return items;
        }

        [Theory]
        [InlineData(1, 9, 19)]
        [InlineData(11, -1, 8)]
        [InlineData(12, -2, 6)]
        [InlineData(14, -4, 2)]
        [InlineData(18, -8, 0)]
        public void Test_Legacy_UpdateItems_StandardItem(int n, int expectedSellIn, int expectedQuality)
        {
            var program = new Program();
            program.Items = LegacyTests.CreateItems();
            for(var i = 0; i < n; i++)
            {
                program.UpdateQuality();
            }
            
            var dexVest = program.Items.Single(item => item.Name.Equals("+5 Dexterity Vest"));
            dexVest.Quality.Should().Be(expectedQuality);
            dexVest.SellIn.Should().Be(expectedSellIn);
        }

        [Theory]
        [InlineData(1, 0, 80)]
        [InlineData(11, 0, 80)]
        [InlineData(12, 0, 80)]
        public void Test_Legacy_UpdateItems_LegendaryItem(int n, int expectedSellIn, int expectedQuality)
        {
            var program = new Program();
            program.Items = LegacyTests.CreateItems();
            for (var i = 0; i < n; i++)
            {
                program.UpdateQuality();
            }

            var legendaryItem = program.Items.Single(item => item.Name.Equals("Sulfuras, Hand of Ragnaros"));
            legendaryItem.Quality.Should().Be(expectedQuality);
            legendaryItem.SellIn.Should().Be(expectedSellIn);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(5, -3, 8)]
        [InlineData(12, -10, 22)]
        public void Test_Legacy_UpdateItems_CheeseItem(int n, int expectedSellIn, int expectedQuality)
        {
            var program = new Program();
            program.Items = LegacyTests.CreateItems();
            for (var i = 0; i < n; i++)
            {
                program.UpdateQuality();
            }

            var cheese = program.Items.Single(item => item.Name.Equals("Aged Brie"));
            cheese.Quality.Should().Be(expectedQuality);
            cheese.SellIn.Should().Be(expectedSellIn);
        }

        [Theory]
        [InlineData(0, 15, 20)]
        [InlineData(1, 14, 21)]
        [InlineData(5, 10, 25)]
        [InlineData(12, 3, 41)]
        public void Test_Legacy_UpdateItems_TicketsItem(int n, int expectedSellIn, int expectedQuality)
        {
            var program = new Program();
            program.Items = LegacyTests.CreateItems();
            for (var i = 0; i < n; i++)
            {
                program.UpdateQuality();
            }

            var ticket = program.Items.Single(item => item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"));
            ticket.Quality.Should().Be(expectedQuality);
            ticket.SellIn.Should().Be(expectedSellIn);
        }
    }
}