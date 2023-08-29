using GildedRose.GildedRoseItem;

namespace GildedRose
{
    class Program
    {
        public IList<Item>? Items { get; set; }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item("+5 Dexterity Vest", 10, 20),
                    new Item("Aged Brie", 2, 0),
                    new Item("Elixir of the Mongoose", 5, 7),
                    new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                    new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                    new Item ("Conjured Mana Cake", 3, 6)
                }
            };

            app.UpdateQuality();

            System.Console.ReadKey();
        }

        public void UpdateQuality()
        {
            if (this.Items == null)
            {
                throw new ArgumentNullException(nameof(this.Items));
            }

            for (var i = 0; i < Items.Count; i++)
            {
                var updatedItem = QualityControl.Tick(Items[i]);
                Items[i] = updatedItem;
            }
        }
    }
}
