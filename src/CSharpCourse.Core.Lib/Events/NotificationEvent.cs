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
        public string EmployeeEmail { get; set; } = string.Empty;
        
        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string EmployeeName { get; set; } = string.Empty;

        /// <summary>
        /// Email менеджера который будет выдавать мерч
        /// </summary>
        public string ManagerEmail { get; set; } = string.Empty;
        
        /// <summary>
        /// ФИО менеджера который будет выдавать мерч
        /// </summary>
        public string ManagerName { get; set; } = string.Empty;
        
        /// <summary>
        /// Тип события.
        /// </summary>
        public EmployeeEventType EventType { get; set; }
        
        /// <summary>
        /// Дополнительные данные по событию.
        /// </summary>
        public object? Payload { get; set; }
    }
}