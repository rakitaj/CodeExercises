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
                _ => TickStandard(item)
            };
            return tickedItem;
        }

        private static Item TickStandard(Item item)
        {
            var tickedQuality = TickQuality(item);
            var tickedItem = new Item(item.Name, item.SellIn - 1, tickedQuality);
            return tickedItem;
        }

        private static Item TickLegendary(Item item)
        {
            return item;
        }

        private static Item TickCheese(Item item)
        {
            var tickedQuality = TickQuality(item, 1);
            var tickedItem = new Item(item.Name, item.SellIn - 1, tickedQuality);
            return tickedItem;
        }

        private static Item TickTickets(Item item)
        {
            var tickedQuality = item.SellIn switch
            {
                <= 0 => 0,
                <= 5 => TickQuality(item, 3),
                <= 10 => TickQuality(item, 2),
                _ => TickQuality(item, 1)
            };
            var tickedItem = new Item(item.Name, item.SellIn - 1, tickedQuality);
            return tickedItem;
        }

        internal static int TickQuality(Item item, int change = -1)
        {
            if (item.SellIn <= 0)
            {
                change = change * 2;
            }
            var updatedQuality = item.Quality + change;
            if (updatedQuality < 0)
            {
                updatedQuality = 0;
            }
            if (updatedQuality > 50)
            {
                updatedQuality = 50;
            }
            return updatedQuality;
        } 
    }
}
