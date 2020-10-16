namespace PromotionEngineConsoleHub.Models
{
    /// <summary>
    /// Product class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Product Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Product Quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
