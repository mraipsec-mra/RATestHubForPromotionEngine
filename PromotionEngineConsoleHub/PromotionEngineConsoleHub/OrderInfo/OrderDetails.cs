using PromotionEngineConsoleHub.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
        public ValueTuple<Promotion, bool, List<BasketItems>> GetApplicablePromotion1OnOrder(List<BasketItems> items)
        {
            var promotionDetails = new ValueTuple<Promotion, bool, List<BasketItems>>();
            var modifiedItems = new List<BasketItems>();

            if (items != null && items.Count > 0)
            {
                var groupedItems = items.GroupBy(p => p.ProductID);

                foreach (var groupedItem in groupedItems)
                {
                    if (groupedItem.Key == "A")
                    {
                        LogicForProductA(modifiedItems, groupedItem);
                    }
                    else if (groupedItem.Key == "B")
                    {
                        LogicForProductB(modifiedItems, groupedItem);
                    }
                    else if (groupedItem.Key == "C")
                    {
                        LogicForProductC(modifiedItems, groupedItem);
                    }
                    else if (groupedItem.Key == "D")
                    {
                        LogicForProductD(modifiedItems, groupedItem);
                    }
                }

                promotionDetails.Item1 = new Promotion() { PromotionID = "AP1", PrintText = "Promotion 1", };
                promotionDetails.Item2 = true;
                promotionDetails.Item3 = modifiedItems;
            }

            return promotionDetails;
        }

        /// <summary>
        /// Get Applicable Promotion 1 On Order
        /// </summary>
        /// <param name="items">basket items</param>
        /// <returns>Promotion Details</returns>
        public ValueTuple<Promotion, bool, List<BasketItems>> GetApplicablePromotion2OnOrder(List<BasketItems> items)
        {
            var promotionDetails = new ValueTuple<Promotion, bool, List<BasketItems>>();
            var modifiedItems = new List<BasketItems>();

            if (items != null && items.Count > 0)
            {
                var selectedItemCCount = items.Where(p => p.ProductID == "C").Count();
                var selectedItemDCount = items.Where(p => p.ProductID == "D").Count();
                if (selectedItemCCount > 0 && selectedItemDCount > 0)
                {
                    if (selectedItemCCount == selectedItemDCount)
                    {
                        modifiedItems.Add(new BasketItems() { ProductID = "C", Price = 0.00, Quantity = selectedItemCCount });
                        modifiedItems.Add(new BasketItems() { ProductID = "D", Price = 30.00, Quantity = selectedItemDCount });
                    }
                    else if(selectedItemCCount < selectedItemDCount)
                    {
                        modifiedItems.Add(new BasketItems() { ProductID = "C", Price = 0.00, Quantity = selectedItemCCount });
                        modifiedItems.Add(new BasketItems() { ProductID = "D", Price = 30.00 * selectedItemCCount, Quantity = selectedItemCCount });
                        modifiedItems.Add(new BasketItems() { ProductID = "D", Price = 15.00, Quantity = selectedItemDCount - selectedItemCCount });
                    }
                    else if(selectedItemCCount > selectedItemDCount)
                    {
                        modifiedItems.Add(new BasketItems() { ProductID = "C", Price = 0.00, Quantity =  selectedItemDCount });
                        modifiedItems.Add(new BasketItems() { ProductID = "D", Price = 30.00 * selectedItemDCount, Quantity = selectedItemDCount });
                        modifiedItems.Add(new BasketItems() { ProductID = "C", Price = 20.00, Quantity = selectedItemCCount - selectedItemDCount });
                    }
                    promotionDetails.Item1 = new Promotion() { PromotionID = "AP2", PrintText = "Promotion 2" };
                    promotionDetails.Item2 = true;
                    promotionDetails.Item3 = modifiedItems;
                }
            }
            return promotionDetails;
        }

        #region Private Methods
        private static void LogicForProductD(List<BasketItems> modifiedItems, IGrouping<string, BasketItems> groupedItem)
        {
            switch (groupedItem.Count())
            {
                default:
                    if (groupedItem.Count() <= 7)
                        modifiedItems.Add(new BasketItems() { Price = 15.00 * groupedItem.Count(), ProductID = "D", Quantity = groupedItem.Count() });
                    break;
            }
        }

        private static void LogicForProductC(List<BasketItems> modifiedItems, IGrouping<string, BasketItems> groupedItem)
        {
            switch (groupedItem.Count())
            {
                default:
                    if (groupedItem.Count() <= 7)
                        modifiedItems.Add(new BasketItems() { Price = 20.00 * groupedItem.Count(), ProductID = "C", Quantity = groupedItem.Count() });
                    break;
            }
        }

        private static void LogicForProductB(List<BasketItems> modifiedItems, IGrouping<string, BasketItems> groupedItem)
        {
            switch (groupedItem.Count())
            {
                case 1:
                    modifiedItems.Add(new BasketItems() { Price = 30.00, ProductID = "B", Quantity = 1 });
                    break;
                case 2:
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    break;
                case 3:
                    modifiedItems.Add(new BasketItems() { Price = 30.00, ProductID = "B", Quantity = 1 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    break;
                case 4:
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    break;
                case 5:
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 30.00, ProductID = "B", Quantity = 1 });
                    break;
                case 6:
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    break;
                case 7:
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 45.00, ProductID = "B", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 30.00, ProductID = "B", Quantity = 1 });
                    break;
                default:
                    break;
            }
        }

        private static void LogicForProductA(List<BasketItems> modifiedItems, IGrouping<string, BasketItems> groupedItem)
        {
            switch (groupedItem.Count())
            {
                case 1:
                    modifiedItems.Add(new BasketItems() { Price = 50.00, ProductID = "A", Quantity = 1 });
                    break;
                case 2:
                    modifiedItems.Add(new BasketItems() { Price = 50.00, ProductID = "A", Quantity = 2 });
                    break;
                case 3:
                    modifiedItems.Add(new BasketItems() { Price = 130.00, ProductID = "A", Quantity = 3 });
                    break;
                case 4:
                    modifiedItems.Add(new BasketItems() { Price = 50.00, ProductID = "A", Quantity = 2 });
                    modifiedItems.Add(new BasketItems() { Price = 50.00, ProductID = "A", Quantity = 2 });
                    break;
                case 5:
                    modifiedItems.Add(new BasketItems() { Price = 130.00, ProductID = "A", Quantity = 3 });
                    modifiedItems.Add(new BasketItems() { Price = 50.00, ProductID = "A", Quantity = 2 });
                    break;
                case 6:
                    modifiedItems.Add(new BasketItems() { Price = 130.00, ProductID = "A", Quantity = 3 });
                    modifiedItems.Add(new BasketItems() { Price = 130.00, ProductID = "A", Quantity = 3 });
                    break;
                case 7:
                    modifiedItems.Add(new BasketItems() { Price = 130.00, ProductID = "A", Quantity = 3 });
                    modifiedItems.Add(new BasketItems() { Price = 130.00, ProductID = "A", Quantity = 3 });
                    modifiedItems.Add(new BasketItems() { Price = 50.00, ProductID = "A", Quantity = 1 });
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
