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
        public Guid? DoctorId { get; set; }
        public int Duration { get; set; }
        public string? Regularity { get; set; }
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }
}