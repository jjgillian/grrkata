using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// this class is an implementation of IItemBehavior which serves as the
    /// contract governing the behaviour for Conjured
    /// type of items with regards to quality and sellin
    /// </summary>
    public class ConjuredItemBehavior : IItemBehavior
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
        public ConjuredItemBehavior(Item item)
        {
            _item = item;
        }

        #endregion



        #region methods

        /// <summary>
        /// this methods updates the sellin of the item.
        /// </summary
        public void UpdateSellin()
        {

            _item.SellIn--;
        }


        /// <summary>
        /// this methods updates the quality of the item. For this type of item,
        /// the quality degrades twice as fast.
        /// The Quality of an item is never negative
        /// </summary>
        public void UpdateQuality()
        {

            _item.Quality -= 2;

            // The Quality of an item is never negative
            if (_item.Quality < 0)
            {
                _item.Quality = 0;
            }
        }

        #endregion
    }
}



