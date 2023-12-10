using WebApi.Models.Enums;

namespace WebApi.Models
{
    public class NotificationDto
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Label { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? Status { get; set; }
        public Guid? DoctorId { get; set; }
        public int Duration { get; set; }
        public string? Regularity { get; set; }
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
