using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// This class encapsulates regular item's behavior
    /// </summary>
    public class RegularItem: GrScItem
    {
        #region constructor
        /// <summary>
        /// for the constructor, since I know that I am a regular item
        /// I will tell my parent to user a regular behavior internally
        /// </summary>
        /// <param name="item">aggregated item</param>
        public RegularItem(Item item)
            :base(new RegularItemBehavior(item))
        {            
        }
        #endregion constructor
    }
}
