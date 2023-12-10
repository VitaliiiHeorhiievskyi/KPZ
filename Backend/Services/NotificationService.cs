using Microsoft.EntityFrameworkCore;
using PatientHealth.DataBase;
using WebApi.Helpers;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models.Enums;

namespace WebApi.Services
{
    public class NotificationService : INotificationService
    {
        private readonly AppDbContext _context;

        public NotificationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Notification> CreateAsync(Notification notification)
        {
            try
            {
                notification.Id = Guid.NewGuid();
                _context.Notifications.Add(notification);
                notification.DoctorId = notification.Doctor?.Id;
                notification.Doctor = null;
                await _context.SaveChangesAsync();
                return notification;
            }
            catch (Exception ex)
            {
                throw;
            }
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

        public async Task<List<NotificationDto>?> GetByPatientIdAsync(Guid patientId)
        {
            try
            {
                return await _context.Notifications.Include(n => n.Doctor)
                    .Where(n => n.PatientId == patientId).Select(n => new NotificationDto
                    {
                        Date = n.Date,
                        Description = n.Description,
                        Doctor = n.Doctor,
                        DoctorId = n.DoctorId,
                        Type = n.Type,
                        Duration = n.Duration,
                        Id = n.Id,
                        Label = n.Label,
                        PatientId = n.PatientId,
                        Regularity = n.Regularity,
                        Status = n.Status
                    }).ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
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

        public async Task ChangeStatusAsync(Guid id, string notificationStatus)
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