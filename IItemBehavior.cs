using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// this interface serves as the contract governing the behaviour or different
    /// types of items with regards to quality and sellin
    /// </summary>
    public interface IItemBehavior
    {
        /// <summary>
        /// the quality returned by this kind of item
        /// </summary>
        int Quality { get;}

        /// <summary>
        /// the sellin returned by this kind of item
        /// </summary>
        int Sellin { get; }

        #region methods

        /// <summary>
        /// this methods updates the sellin of the item
        /// </summary>
        void UpdateSellin();

        /// <summary>
        /// this methods updates the quality of the item
        /// </summary>
        void UpdateQuality();


        #endregion methods
    }
}
