
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// This class encapsulates aged brie item's behavior
    /// </summary>
    public class AgedBrieItem : GrScItem
    {
        #region constructor
        /// <summary>
        /// for the constructor, since I know that I am a AgedBrie item
        /// I will tell my parent to user a aged brie behavior internally
        /// </summary>
        /// <param name="item">aggregated item</param>
        public AgedBrieItem(Item item)
            : base(new AgedBrieBehavior(item))
        {
        }
        #endregion constructor
    }
}
