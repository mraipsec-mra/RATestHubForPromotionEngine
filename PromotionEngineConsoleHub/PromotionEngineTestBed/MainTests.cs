using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineConsoleHub.Models;
using PromotionEngineConsoleHub.OrderInfo;
using System.Collections.Generic;

namespace PromotionEngineTestBed
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void TestMethodForPromotion1Set1()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "D" });
            var items = new OrderDetails().GetApplicablePromotion1OnOrder(basketItems);
            Assert.IsNotNull(items.Item1);
        }
    }
}
