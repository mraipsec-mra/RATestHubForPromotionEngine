
using System.Collections.Generic;

namespace PromotionEngineConsoleHub.Models
{
    /// <summary>
    /// Order 
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Basket Items
        /// </summary>
        public List<BasketItems> Items { get; set; }

        /// <summary>
        /// Promotions
        /// </summary>
        public List<Promotion> Promotions { get; set; }
    }
}
