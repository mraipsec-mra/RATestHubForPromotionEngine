using PromotionEngineConsoleHub.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngineConsoleHub.OrderInfo
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
        /// <returns>Promotion Details</returns>
        public ValueTuple<Promotion, bool> GetApplicablePromotion1OnOrder(List<BasketItems> items)
        {
            var promotionDetails = new ValueTuple<Promotion, bool>();
            promotionDetails.Item1 = new Promotion() { PromotionID = "AP1", PrintText = "Promotion 1" };
            promotionDetails.Item2 = true;
            return promotionDetails;
        }

        /// <summary>
        /// Get Applicable Promotion 1 On Order
        /// </summary>
        /// <param name="items">basket items</param>
        /// <returns>Promotion Details</returns>
        public ValueTuple<Promotion, bool> GetApplicablePromotion2OnOrder(List<BasketItems> items)
        {
            var promotionDetails = new ValueTuple<Promotion, bool>();
            promotionDetails.Item1 = new Promotion() { PromotionID = "AP2", PrintText = "Promotion 2" };
            promotionDetails.Item2 = true;
            return promotionDetails;
        }
    }
}
