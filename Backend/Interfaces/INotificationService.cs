using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Interfaces
{
    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetAllAsync();
        Task<Notification?> GetByIdAsync(Guid id);
        Task<Notification> CreateAsync(Notification notification);
        Task UpdateAsync(Guid id, Notification notification);
        Task DeleteAsync(Guid id);
        Task ChangeStatusAsync(Guid id, NotificationStatusEnum notificationStatus);
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task<List<Notification>?> GetByPatientIdAsync(Guid patientId);
    }
}
