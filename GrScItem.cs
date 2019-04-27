using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// this interface serves as the contract for an extended Gilded Rose Item
    /// which is needed since the gilded rose "Item" class cannot be changed
    /// </summary>
    public class GrScItem : IGrScItem
    {
        #region private variables
        /// <summary>
        /// remembers if we have already updated the quality for the day
        /// </summary>
        private bool _alreadyUpdatedToday;

        /// <summary>
        /// this property encapsulates the specific Sellin and Quality behavior of the item depending
        /// on what type of item it is.
        /// </summary>
        private IItemBehavior _itemBehavior;
        #endregion private variables

        #region IGrScItem implementation
        /// <summary>
        /// this method updates the quality of the item depending on the
        /// kind of item and the sellin
        /// </summary>
        public void UpdateQuality()
        {
            _itemBehavior.UpdateSellin();
            _itemBehavior.UpdateQuality();
        }

        /// <summary>
        /// the quality returned by this kind of item
        /// </summary>
        public int Quality
        {
            get { return _itemBehavior.Quality; }
        }

        /// <summary>
        /// the sellin returned by this kind of item
        /// </summary>
        public int Sellin
        {
            get { return _itemBehavior.Sellin; }
        }

        #endregion IGrScItem implementation

        #region constructor

        public GrScItem(IItemBehavior itemBehavior)
        {
            _itemBehavior = itemBehavior;
        }
        #endregion constructor

    }
}
