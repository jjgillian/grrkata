using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        #region private helpers

        /// <summary>
        /// creates the proper IGrScItem based on the name of the item
        /// </summary>
        /// <param name="item">item</param>
        /// <returns>IGrScItem</returns>
        private IGrScItem GrScItemFactory(Item item)
        {
            if (string.IsNullOrEmpty(item.Name.Trim()))
            {
                return null;
            }

            string lowerItemName = item.Name.ToLower();
            
            if (lowerItemName.Contains("aged brie"))
            {
                return new AgedBrieItem(item);
            }

            if (lowerItemName.Contains("backstage passes"))
            {
                return new BackStageItem(item);
            }

            if (lowerItemName.Contains("sulfuras"))
            {
                return new SulfurusItem(item);
            }

            if (lowerItemName.Contains("conjured"))
            {
                return new ConjuredItem(item);
            }

            return new RegularItem(item);
        }
        #endregion private helper

        private bool _hasBeenRunToday;

        IList<Item> Items;
        public GildedRose(IList<Item> Items, bool hasBeenRunToday)
        {
            this.Items = Items;
            this._hasBeenRunToday = hasBeenRunToday;
        }

        public void UpdateQuality()
        {
            // create an smooth criminal version of a gilded rose item
            // through the smooth criminals gilded rose factory using the name of
            // the item

            if (this._hasBeenRunToday)
            {
                return;
            }

            // update my internal status that I have already updated the items
            _hasBeenRunToday = true;

            for (var i = 0; i < Items.Count; i++)
            {
                IGrScItem grScItem = GrScItemFactory(Items[i]);
                grScItem.UpdateQuality();
                Items[i].Quality = grScItem.Quality;
                Items[i].SellIn = grScItem.Sellin;
            }
            
        }
    }
}
