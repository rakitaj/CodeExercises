using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.GildedRoseItem
{
    internal class LegendaryItem : Item
    {
        public LegendaryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void Tick(int change = -1)
        {
            // Intentionally do nothing for legendary items.
        }
    }
}
