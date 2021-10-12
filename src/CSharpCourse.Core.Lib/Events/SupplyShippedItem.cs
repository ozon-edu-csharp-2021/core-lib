namespace CSharpCourse.Core.Lib.Events
{
    public class SupplyShippedItem
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public long SkuId { get; set; }
    
        /// <summary>
        /// Количество товаров.
        /// </summary>
        public long Quantity { get; set; }
    }
}