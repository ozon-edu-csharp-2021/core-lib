namespace CSharpCourse.Core.Lib.Models
{
    public class StockReplenishedItem
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public long Sku { get; set; }

        /// <summary>
        /// Идентификатор типа товара 
        /// </summary>
        public int ItemTypeId { get; set; }

        /// <summary>
        /// Название типа товара
        /// </summary>
        public string ItemTypeName { get; set; } = string.Empty;

        /// <summary>
        /// Размер позиции, если он есть
        /// </summary>
        public int? ClothingSize { get; set; }
    }
}