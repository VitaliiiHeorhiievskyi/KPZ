using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Helpers
{
    public static class EnumHelper
    {
        public static string GetNotificationTypeString(NotificationTypeEnum notificationType)
        {
            return notificationType switch
            {
                NotificationTypeEnum.Appointment => "APPOINTMENT",
                NotificationTypeEnum.Prescription => "PRESCRIPTION",
                _ => throw new ArgumentOutOfRangeException(nameof(notificationType), notificationType, null)
            };
        }

        public static string GetSexString(Sex sex)
        {
            return sex switch
            {
                Sex.Male => "MALE",
                Sex.Female => "FEMALE",
                _ => throw new ArgumentOutOfRangeException(nameof(sex), sex, null)
            };
        }

        public static string GetNotificationStatusString(NotificationStatusEnum notificationStatus)
        {
            return notificationStatus switch
            {
                NotificationStatusEnum.Pending => "PENDING",
                NotificationStatusEnum.Active => "ACTIVE",
                NotificationStatusEnum.Rejected => "REJECTED",
                _ => throw new ArgumentOutOfRangeException(nameof(notificationStatus), notificationStatus, null)
            };
        }
    }
}
