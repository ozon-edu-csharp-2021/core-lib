using System;
using System.Collections.Generic;
using CSharpCourse.Core.Lib.Abstractions;
using CSharpCourse.Core.Lib.Models;

namespace CSharpCourse.Core.Lib.Events
{
    /// <summary>
    /// Событие которое генерируется сервисом Stock-Api когда пополняется запасы на складе
    /// </summary>
    /// <remarks>Данное событие перехватывается сервисом Merchendize для активации повтороной выдачи мерча</remarks>
    public class StockReplenishedEvent : IKafkaMessage
    {
        /// <summary>
        /// Коллекция пополненных товаров
        /// </summary>
        public IReadOnlyCollection<StockReplenishedItem> Type { get; set; } = Array.Empty<StockReplenishedItem>();
    }
}