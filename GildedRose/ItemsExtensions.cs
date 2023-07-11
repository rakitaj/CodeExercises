namespace GildedRose
{
    internal static class ItemsExtensions
    {
        internal static Item Get(this List<Item> items, string name) 
        {
            return items.Single(item => item.Name.Equals(name));
        }
    }
}
