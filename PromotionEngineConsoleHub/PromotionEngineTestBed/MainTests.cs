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
            Assert.IsNotNull(items.Item3);
        }

        [TestMethod]
        public void TestMethodForPromotion1Set2()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "D" });
            var items = new OrderDetails().GetApplicablePromotion1OnOrder(basketItems);
            Assert.IsNotNull(items.Item3);
            Assert.IsTrue(items.Item3.Count == 4);
        }

        [TestMethod]
        public void TestMethodForPromotion1Set3()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "C" });
            var items = new OrderDetails().GetApplicablePromotion1OnOrder(basketItems);
            Assert.IsNotNull(items.Item3);
            Assert.IsTrue(items.Item3.Count == 6);
        }

        [TestMethod]
        public void TestMethodForPromotion1Set4()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "A" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "B" });
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "D" });
            var items = new OrderDetails().GetApplicablePromotion1OnOrder(basketItems);
            Assert.IsNotNull(items.Item3);
            Assert.IsTrue(items.Item3.Count == 6);
        }

        [TestMethod]
        public void TestMethodForPromotion2Set1()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "D" });
            var items = new OrderDetails().GetApplicablePromotion2OnOrder(basketItems);
            Assert.IsNotNull(items.Item3);
            Assert.IsTrue(items.Item3.Count == 2);
        }

        [TestMethod]
        public void TestMethodForPromotion2Set2()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "D" });
            var items = new OrderDetails().GetApplicablePromotion2OnOrder(basketItems);
            Assert.IsNotNull(items.Item3);
            Assert.IsTrue(items.Item3.Count == 3);
        }

        [TestMethod]
        public void TestMethodForPromotion2Set3()
        {
            var basketItems = new List<BasketItems>();
            basketItems.Add(new BasketItems() { ProductID = "D" });
            basketItems.Add(new BasketItems() { ProductID = "C" });
            basketItems.Add(new BasketItems() { ProductID = "D" });
            var items = new OrderDetails().GetApplicablePromotion2OnOrder(basketItems);
            Assert.IsNotNull(items.Item3);
            Assert.IsTrue(items.Item3.Count == 3);
        }
    }
}
