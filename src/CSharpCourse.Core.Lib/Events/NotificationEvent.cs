using CSharpCourse.Core.Lib.Abstractions;
using CSharpCourse.Core.Lib.Enums;

namespace CSharpCourse.Core.Lib.Events
{
    /// <summary>
    /// Модель события, требующего нотификации сотрудника по почте.
    /// </summary>
    public class NotificationEvent : IKafkaMessage
    {
        /// <summary>
        /// Email сотрудника.
        /// </summary>
        public string EmployeeEmail { get; set; }
        
        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string EmployeeName { get; set; }
        
        /// <summary>
        /// Тип события.
        /// </summary>
        public EmployeeEventType EventType { get; set; }
        
        /// <summary>
        /// Дополнительные данные по событию.
        /// </summary>
        public NotificationEventPayload Payload { get; set; }
    }
}