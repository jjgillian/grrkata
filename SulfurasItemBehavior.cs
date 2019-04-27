
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// this class is an implementation of IItemBehavior which serves as the
    /// contract governing the behaviour for Sulfuras
    /// type of items with regards to quality and sellin
    /// </summary>
    public class SulfurasItemBehavior : IItemBehavior
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
        public SulfurasItemBehavior(Item item)
        {
            _item = item;
        }

        #endregion


        #region methods

        /// <summary>
        /// this method doesn't update the sellin, because it never has to be sold 
        /// </summary
        public void UpdateSellin()
        {        
        }


        /// <summary>
        /// this methods updates the quality of the item. For this type of item,
        /// the quality will be changed to 80, if it wasn't originally 80.
        /// </summary>
        public void UpdateQuality()
        {
            _item.Quality = 80;       
        }

        #endregion
    }
}

