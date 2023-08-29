using GildedRose.GildedRoseItem;

namespace GildedRose
{
    public class QualityControl
    {
        internal static Item Tick(Item item)
        {
            var tickedItem = item.Name switch
            {
                "Aged Brie" => TickCheese(item),
                "Backstage passes to a TAFKAL80ETC concert" => TickTickets(item),
                "Sulfuras, Hand of Ragnaros" => TickLegendary(item),
                "Conjured Mana Cake" => TickConjured(item),
                _ => TickStandard(item)
            };
            return tickedItem;
        }

        private static Item TickConjured(Item item)
        {
            // var tickedQuality = TickQuality(item, -2);
            // var tickedItem = new Item(item.Name, item.SellIn - 1, tickedQuality);
            item.Tick(-2);
            return item;
        }

        private static Item TickStandard(Item item)
        {
            // var tickedQuality = TickQuality(item);
            //var tickedItem = new Item(item.Name, item.SellIn - 1, tickedQuality);
            item.Tick();
            return item;
        }

        private static Item TickLegendary(Item item)
        {
            return item;
        }

        private static Item TickCheese(Item item)
        {
            // var tickedQuality = TickQuality(item, 1);
            // var tickedItem = new Item(item.Name, item.SellIn - 1, tickedQuality);
            item.Tick(1);
            return item;
        }

        private static Item TickTickets(Item item)
        {
            //var foo = item.SellIn switch
            //{
            //    <= 0 => item.Quality.Change(0),
            //    <= 5 => item.Quality.Change(3),
            //    <= 10 => item.Quality.Change(2),
            //    _ => item.Quality.Change(1)
            //};
            item.SellIn -= 1;
            return item;
        }
    }
}
