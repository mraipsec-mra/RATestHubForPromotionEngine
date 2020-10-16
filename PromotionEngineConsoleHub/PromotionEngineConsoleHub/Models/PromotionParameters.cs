namespace PromotionEngineConsoleHub.Models
{
    /// <summary>
    /// Promotion Parameters
    /// </summary>
    public class PromotionParameters
    {
        /// <summary>
        /// Promotion Type
        /// </summary>
        public string PromotionType { get; set; } 

        /// <summary>
        /// Apply Rule 
        /// </summary>
        public bool ApplyRule { get; set; }
        
        /// <summary>
        /// Items Quantity
        /// </summary>
        public double Quantity { get; set; }

    }
}
