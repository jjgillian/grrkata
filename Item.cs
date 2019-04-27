namespace csharp
{
    public class Item
    {
        /// <summary>
        /// the name of the item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// SellIn value which denotes the number of days we have to sell the item
        /// At the end of each day our system lowers the value for Sellin
        /// 1. Sellin is calculated by decre
        /// 2. The item is updated when the UpdateQuality() method runs.
        /// 3. The sellin is decremented by 1 at the end of each day.
        /// </summary>
        public int SellIn { get; set; }
        /// <summary>
        /// Quality value which denotes how valuable the item is.
        /// At the end of each day our system lowers the value for quality        
        /// </summary>
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }  
    }
}
