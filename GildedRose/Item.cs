namespace GildedRose
{
    internal class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Item(string name, int sellIn, int quality) 
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }
    }
}
