

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// This class encapsulates back stage pass item's behavior
    /// </summary>
    public class BackStageItem : GrScItem
    {
        #region constructor
        /// <summary>
        /// for the constructor, since I know that I am a back stage pass item
        /// I will tell my parent to user a back stage pass item behavior internally
        /// </summary>
        /// <param name="item">aggregated item</param>
        public BackStageItem(Item item)
            : base(new BackstageItemBehavior(item))
        {
        }
        #endregion constructor
    }
}
