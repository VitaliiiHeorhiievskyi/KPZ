using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Models.Enums;

namespace PatientHealth.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call the base OnModelCreating method
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Notification>().HasData(
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Prescription,
                    Label = "Appointment Reminder",
                    Description = "Don't forget your appointment tomorrow at 10 AM.",
                    Date = DateTime.Now.AddDays(1),
                    Status = NotificationStatusEnum.Active,
                    Doctor = "Dr. Smith",
                    Duration = 30,
                    Regularity = "Once"
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Appointment,
                    Label = "Medication Reminder",
                    Description = "Time to take your medication.",
                    Date = DateTime.Now.AddHours(6),
                    Status = NotificationStatusEnum.Rejected,
                    Doctor = "Dr. Jones",
                    Duration = 0,
                    Regularity = "Daily"
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Prescription,
                    Label = "Lab Results",
                    Description = "Your recent lab results are ready for review.",
                    Date = DateTime.Now.AddDays(2),
                    Status = NotificationStatusEnum.Active,
                    Doctor = "Dr. Green",
                    Duration = 0,
                    Regularity = "Once"
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Appointment,
                    Label = "Follow-up Reminder",
                    Description = "Remember to schedule your follow-up appointment.",
                    Date = DateTime.Now.AddDays(7),
                    Status = NotificationStatusEnum.Pending,
                    Doctor = "Dr. White",
                    Duration = 0,
                    Regularity = "Once"
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Prescription,
                    Label = "Health Tips",
                    Description = "Check out the latest health tips on our website.",
                    Date = DateTime.Now.AddDays(3),
                    Status = NotificationStatusEnum.Rejected,
                    Doctor = null,
                    Duration = 0,
                    Regularity = "Weekly"
                }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Smith",
                    Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua"
                },
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. White",
                    Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua"
                },
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Green",
                    Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua"
                },
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Jones",
                    Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua"
                },
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Laura Garcia",
                    Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua"
                }
            );
        }
    }
}