namespace GildedRose.GildedRoseItem
{
    internal class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public Quality Quality { get; set; }

        public Item(string name, int sellIn, int quality) : this(name, sellIn, new Quality(quality))
        {

        }

        public Item(string name, int sellIn, Quality quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public virtual void Tick(int change = -1)
        {
            if (this.SellIn <= 0)
            {
                change = change * 2;
            }
            this.Quality.Change(change);
            this.SellIn -= 1;
        }
    }
}
