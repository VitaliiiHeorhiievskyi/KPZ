using WebApi.Models.Enums;

namespace WebApi.Models
{
    public class Notification
    {
        public Guid Id { get; set; }
        public NotificationTypeEnum Type { get; set; }
        public string? Label { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public NotificationStatusEnum Status { get; set; }
        public string? Doctor { get; set; }
        public int Duration { get; set; }
        public string? Regularity { get; set; }
    }
}
