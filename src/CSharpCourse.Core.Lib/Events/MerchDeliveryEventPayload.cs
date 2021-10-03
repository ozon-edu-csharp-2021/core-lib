using CSharpCourse.Core.Lib.Enums;

namespace CSharpCourse.Core.Lib.Events
{
    /// <summary>
    /// Информация по событию "выдача мерча".
    /// </summary>
    public class MerchDeliveryEventPayload : INotificationEventPayload
    {
        /// <summary>
        /// Тип выдаваемого мерча.
        /// </summary>
        public MerchType MerchType { get; set; }
    }
}