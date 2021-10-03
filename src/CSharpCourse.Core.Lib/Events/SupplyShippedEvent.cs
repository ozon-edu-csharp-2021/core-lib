using System;
using System.Collections.Generic;
using CSharpCourse.Core.Lib.Abstractions;

namespace CSharpCourse.Core.Lib.Events
{
    public class SupplyShippedEvent : IKafkaMessage
    {
        public long SupplyId { get; set; }

        public ICollection<Item> Items { get; set; } = Array.Empty<Item>();

        public class Item
        {
            public long SkuId { get; set; }

            public long Quantity { get; set; }
        }
    }
}