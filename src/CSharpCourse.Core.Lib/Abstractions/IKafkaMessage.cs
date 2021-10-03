using System;

namespace CSharpCourse.Core.Lib.Abstractions
{
    /// <summary>
    /// Базовый интерфейс для Kafka сообщения.
    /// </summary>
    public interface IKafkaMessage
    {
        public Guid MessageId => Guid.NewGuid();
    }
}