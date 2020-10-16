using PromotionEngineConsoleHub.Models;
using PromotionEngineConsoleHub.OrderInfo;
using System.Collections.Generic;

namespace PromotionEngineConsoleHub.RulesEngine
{
    /// <summary>
    /// Rules Engine
    /// </summary>
    public class RulesEngine
    {
        /// <summary>
        /// Basket items
        /// </summary>
        public List<BasketItems> Items { get; private set;  }

        /// <summary>
        /// Available Promotions
        /// </summary>
        public List<Promotion> AvailablePromotions { get; private set; }
     
        /// <summary>
        /// Order Information
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Rules Engine Constructor
        /// </summary>
        public RulesEngine()
        {
            this.Order = new Order();
        }

        /// <summary>
        /// Populate basket items
        /// </summary>
        /// <param name="items">Basket Items</param>
        /// <returns>boolean value based on api success or failure</returns>
        public bool PopulateBasketItems(List<BasketItems> items)
        {
            //Replace with api call.
            this.Order.Items = items;
            this.Items = items;
            return true;
        }

        /// <summary>
        /// Populate available promotions
        /// </summary>
        /// <param name="promotions">available promotions</param>
        /// <returns>boolean based on api success or failure</returns>
        public bool PopulateAvailablePromotions(List<Promotion> promotions)
        {
            this.AvailablePromotions = promotions;
            return true;
        }

        /// <summary>
        /// Compute Order
        /// </summary>
        /// <returns>boolean value based on computation success / failure</returns>
        public bool ComputeOrder()
        {
            /* Rule 1 */
            var promotion1 = new OrderDetails().GetApplicablePromotion1OnOrder(this.Items);

            if(promotion1.Item2)
            {
                this.Order.Promotions.Add(promotion1.Item1);
            }


            /* Rule 2 */
            var promotion2 = new OrderDetails().GetApplicablePromotion2OnOrder(this.Items);

            if (promotion2.Item2)
            {
                this.Order.Promotions.Add(promotion2.Item1);
            }

            return true;
        }
    }
}
