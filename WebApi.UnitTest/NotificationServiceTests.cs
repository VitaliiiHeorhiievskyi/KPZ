using Microsoft.EntityFrameworkCore;
using Moq;
using PatientHealth.DataBase;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Models.Enums;
using WebApi.Services;

namespace WebApi.UnitTest
{
    public class NotificationServiceTests
    {
        private readonly NotificationService _notificationService;
        private readonly AppDbContext _dbContext;
        private readonly Mock<DbSet<Notification>> _mockNotificationSet;
        private readonly Mock<DbSet<Doctor>> _mockDoctorSet;

        private DbContextOptions<AppDbContext> CreateInMemoryDbContextOptions(string databaseName)
        {
            return new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: databaseName)
                .Options;
        }

        public NotificationServiceTests()
        {
            var dbContextOptions = CreateInMemoryDbContextOptions("InMemory_Test_Database");
            _dbContext = new AppDbContext(dbContextOptions);

            _notificationService = new NotificationService(_dbContext);

            _mockNotificationSet = new Mock<DbSet<Notification>>();
            _mockDoctorSet = new Mock<DbSet<Doctor>>();

            SeedDatabase();
        }

        private void SeedDatabase()
        {
            _dbContext.Notifications.RemoveRange(_dbContext.Notifications);
            _dbContext.SaveChanges();

            var testNotifications = new List<Notification>
            {
                new Notification
                {
                    Id = Guid.Parse("10deeb30-6cbd-4349-b45e-c979fd84c52f")
                }
            };

            _dbContext.Notifications.AddRange(testNotifications);
            _dbContext.SaveChanges();
        }

        [Fact]
        public async Task CreateAsync_ShouldAddNotification()
        {
            var notification = new Notification { /* initialize properties */ };

            await _notificationService.CreateAsync(notification);

            var savedNotification = await _dbContext.Notifications.FindAsync(notification.Id);
            Assert.NotNull(savedNotification);
            Assert.Equal(notification.Id, savedNotification.Id);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllNotifications()
        {
            SeedDatabase();

            var result = await _notificationService.GetAllAsync();

            Assert.Equal(_dbContext.Notifications.AsNoTracking().Count(), result.Count());
        }

        [Fact]
        public async Task DeleteAsync_ShouldRemoveNotification()
        {
            SeedDatabase(); // Assuming there are some seeded notifications

            var notificationId = Guid.Parse("10deeb30-6cbd-4349-b45e-c979fd84c52f");
            await _notificationService.DeleteAsync(notificationId);

            var notification = await _dbContext.Notifications.FindAsync(notificationId);
            Assert.Null(notification);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnNotification()
        {
            var notificationId = Guid.NewGuid();
            var expectedNotification = new Notification { Id = notificationId, /* other properties */ };

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("GetByIdAsync_Test")))
            {
                context.Notifications.Add(expectedNotification);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("GetByIdAsync_Test")))
            {
                var service = new NotificationService(context);
                var result = await service.GetByIdAsync(notificationId);

                Assert.NotNull(result);
                Assert.Equal(notificationId, result.Id);
            }
        }

        [Fact]
        public async Task GetByPatientIdAsync_ShouldReturnNotificationsForPatient()
        {
            var patientId = Guid.NewGuid();
            var expectedNotifications = new List<Notification>
            {
                new Notification { PatientId = patientId, /* other properties */ },
                new Notification { PatientId = patientId, /* other properties */ }
            };

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("GetByPatientIdAsync_Test")))
            {
                context.Notifications.AddRange(expectedNotifications);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("GetByPatientIdAsync_Test")))
            {
                var service = new NotificationService(context);
                var result = await service.GetByPatientIdAsync(patientId);

                Assert.NotNull(result);
                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateNotification()
        {
            var notificationId = Guid.NewGuid();
            var originalNotification = new Notification { Id = notificationId, /* initial properties */ };
            var updatedNotification = new Notification { Id = notificationId, /* updated properties */ };

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("UpdateAsync_Test")))
            {
                context.Notifications.Add(originalNotification);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("UpdateAsync_Test")))
            {
                var service = new NotificationService(context);
                await service.UpdateAsync(notificationId, updatedNotification);
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("UpdateAsync_Test")))
            {
                var notification = await context.Notifications.FindAsync(notificationId);
                // Assert that properties are updated as expected
                Assert.Equal(updatedNotification.Id, notification.Id);
                // More assertions as necessary
            }
        }

        [Fact]
        public async Task ChangeStatusAsync_ShouldUpdateNotificationStatus()
        {
            var notificationId = Guid.NewGuid();
            var notification = new Notification { Id = notificationId, Status = NotificationStatusEnum.Pending /* initial status */ };

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("ChangeStatusAsync_Test")))
            {
                context.Notifications.Add(notification);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("ChangeStatusAsync_Test")))
            {
                var service = new NotificationService(context);
                await service.ChangeStatusAsync(notificationId, NotificationStatusEnum.Active);
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("ChangeStatusAsync_Test")))
            {
                var updatedNotification = await context.Notifications.FindAsync(notificationId);
                Assert.Equal(NotificationStatusEnum.Active, updatedNotification.Status);
            }
        }

        [Fact]
        public async Task GetAllDoctorsAsync_ShouldReturnAllDoctors()
        {
            var expectedDoctors = new List<Doctor>
            {
                new Doctor { Id = Guid.Parse("24582a5e-2682-4a94-a7a6-1948d12d912a") },
                new Doctor { Id = Guid.Parse("4b154f84-ff14-4baf-be8d-4497ca641dfe") }
            };

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("GetAllDoctorsAsync_Test")))
            {
                context.Doctors.AddRange(expectedDoctors);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(CreateInMemoryDbContextOptions("GetAllDoctorsAsync_Test")))
            {
                var service = new NotificationService(context);
                var result = await service.GetAllDoctorsAsync();

                Assert.NotNull(result);
                Assert.Equal(expectedDoctors.Count, result.Count());
            }
        }
    }
}
