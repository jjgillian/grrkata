


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// This class encapsulates Sulfurus item's behavior
    /// </summary>
    public class SulfurusItem : GrScItem
    {
        #region constructor

        /// <summary>
        /// for the constructor, since I know that I am a Sulfurus item
        /// I will tell my parent to user a Sulfurus item behavior internally
        /// </summary>
        /// <param name="item">aggregated item</param>
        public SulfurusItem(Item item)
            : base(new SulfurasItemBehavior(item))
        {
        }
        #endregion constructor
    }
}
