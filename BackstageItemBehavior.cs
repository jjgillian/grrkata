using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// this class is an implementation of IItemBehavior which serves as the
    /// contract governing the behaviour for Backstage Pass Item
    /// type of items with regards to quality and sellin
    /// </summary>
    public class BackstageItemBehavior : IItemBehavior
    {
        /// <summary>
        /// the quality returned by this kind of item
        /// </summary>
        public int Quality
        {
            get { return _item.Quality; }
        }

        /// <summary>
        /// the sellin returned by this kind of item
        /// </summary>
        public int Sellin
        {
            get { return _item.SellIn; }
        }

        /// <summary>
        /// this is the specific kind of item
        /// </summary>
        private Item _item;

        #region constructor

        /// <param name="item">aggregated item</param>
        public BackstageItemBehavior(Item item)
        {
            _item = item;
        }

        #endregion



        #region methods

        /// <summary>
        /// this methods updates the sellin of the item
        /// </summary>
        public void UpdateSellin()
        {
            _item.SellIn--;
        }

        /// <summary>
        /// this methods updates the quality of the item. "Aged Brie" actually increases in Quality the older it gets.
        /// The Quality of an item is never more than 50.
        /// We will take the liberty of adjusting the item quality to 50 if it's above 50. This is an extension of the rule
        /// and approved by the product owner.
        /// </summary>
        public void UpdateQuality()
        {
            // increases in Quality as its SellIn value approaches;
            //Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less b
            //Quality drops to 0 after the concert

            if(_item.SellIn > 10)
            {
                _item.Quality++;
            }
            else if (_item.SellIn < 11 && _item.SellIn > 5)
            {
                _item.Quality +=2;
            }
            else if (_item.SellIn < 6 && _item.SellIn >= 0)
            {
                _item.Quality += 3;
            }
            else
            {
                _item.Quality = 0;
            }
            // The Quality of an item is never more than 50
           if (_item.Quality >50)
            {
                _item.Quality = 50;
            }
        }

        #endregion
    }
}
