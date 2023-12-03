using Microsoft.EntityFrameworkCore;
using PatientHealth.DataBase;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Services
{
    public class NotificationService: INotificationService
    {
        private readonly AppDbContext _context;

        public NotificationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Notification> CreateAsync(Notification notification)
        {
            notification.Id = Guid.NewGuid();
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
            return notification;
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await _context.Notifications.ToListAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Notification?> GetByIdAsync(Guid id)
        {
            return await _context.Notifications.FindAsync(id);
        }

        public async Task UpdateAsync(Guid id, Notification notification)
        {
            var existingNotification = await _context.Notifications.FindAsync(id);
            if (existingNotification != null)
            {
                existingNotification.Type = notification.Type;
                existingNotification.Label = notification.Label;
                existingNotification.Date = notification.Date;
                existingNotification.Description = notification.Description;
                existingNotification.Status = notification.Status;
                existingNotification.Duration = notification.Duration;
                existingNotification.Doctor = notification.Doctor;
                existingNotification.Regularity = notification.Regularity;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var notification = await _context.Notifications.FindAsync(id);
            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                await _context.SaveChangesAsync();
            }
        }

        public async Task ChangeStatusAsync(Guid id, NotificationStatusEnum notificationStatus)
        {
            var existingNotification = await _context.Notifications.FindAsync(id);
            if (existingNotification != null)
            {
                existingNotification.Status = notificationStatus;

                await _context.SaveChangesAsync();
            }
        }
    }
}
