using System;
using System.Collections.Generic;
using CSharpCourse.Core.Lib.Abstractions;

namespace CSharpCourse.Core.Lib.Events
{
    public class SupplyShippedEvent : IKafkaMessage
    {
        /// <summary>
        /// Идентификатор поставки.
        /// </summary>
        public long SupplyId { get; set; }
    
        /// <summary>
        /// Коллекция товаров в поставке.
        /// </summary>
        public ICollection<SupplyShippedItem> Items { get; set; } = Array.Empty<SupplyShippedItem>();
    }
}