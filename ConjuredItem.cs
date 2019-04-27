using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// This class encapsulates conjured item's behavior
    /// </summary>
    public class ConjuredItem : GrScItem
    {
        #region constructor
        /// <summary>
        /// for the constructor, since I know that I am a conjured item
        /// I will tell my parent to user a conjured behavior internally
        /// </summary>
        /// <param name="item">aggregated item</param>
        public ConjuredItem(Item item)
            : base(new ConjuredItemBehavior(item))
        {
        }
        #endregion constructor
    }
}
