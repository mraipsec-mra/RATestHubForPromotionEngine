using PromotionEngineConsoleHub.Models;
using System.Collections.Generic;

namespace PromotionEngineConsoleHub.Order
{
    /// <summary>
    /// Order Details
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// Get Applicable Promotion 1 On Order
        /// </summary>
        /// <param name="items">basket items</param>
        /// <returns></returns>
        public bool GetApplicablePromotion1OnOrder(List<BasketItems> items)
        {
            return true;
        }

        public bool GetApplicablePromotion2OnOrder(List<BasketItems> items)
        {
            return true;
        }
    }
}
