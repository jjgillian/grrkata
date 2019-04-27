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
    public interface IGrScItem
    {
        /// <summary>
        /// this method updates the quality of the item depending on the
        /// kind of item and the sellin
        /// </summary>
        void UpdateQuality();

        /// <summary>
        /// the quality returned by this kind of item
        /// </summary>
        int Quality { get; }

        /// <summary>
        /// the sellin returned by this kind of item
        /// </summary>
        int Sellin { get; }
    }
}
