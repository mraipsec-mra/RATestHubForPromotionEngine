using PromotionEngineConsoleHub.Models;
using PromotionEngineConsoleHub.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineConsoleHub.RulesEngine
{
    /// <summary>
    /// Rules Engine
    /// </summary>
    public class RulesEngine
    {
        /// <summary>
        /// basket items
        /// </summary>
        public List<BasketItems> Items { get; private set;  }

        /// <summary>
        /// Rules Engine Constructor
        /// </summary>
        public RulesEngine()
        {

        }

        /// <summary>
        /// Populate basket items
        /// </summary>
        /// <param name="items">Basket Items</param>
        /// <returns>boolean value based on api success or failure</returns>
        public bool PopulateBasketItems(List<BasketItems> items)
        {
            //Replace with api call.
            this.Items = items;
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
            /* Rule 2 */
            var promotion2 = new OrderDetails().GetApplicablePromotion2OnOrder(this.Items);
            return true;
        }
    }
}
