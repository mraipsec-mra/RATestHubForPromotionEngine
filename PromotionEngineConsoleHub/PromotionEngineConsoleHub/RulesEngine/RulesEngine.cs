using PromotionEngineConsoleHub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineConsoleHub.RulesEngine
{
    public class RulesEngine
    {
        public List<BasketItems> Items { get; private set;  }
        public RulesEngine()
        {

        }

        public bool PopulateBasketItems(List<BasketItems> items)
        {
            this.Items = items;
            return true;
        }
    }
}
