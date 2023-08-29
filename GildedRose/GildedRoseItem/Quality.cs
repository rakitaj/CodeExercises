namespace GildedRose.GildedRoseItem
{
    public class Quality
    {
        public int Value { get; private set; }

        public Quality(int value)
        {
            this.Value = value;
        }

        public void Change(int delta)
        {
            this.Value += delta;
            this.Constrain();
        }

        private void Constrain()
        {
            if (this.Value > 50)
            {
                this.Value = 50;
            }
            if (this.Value < 0)
            {
                this.Value = 0;
            }
        }
    }
}
