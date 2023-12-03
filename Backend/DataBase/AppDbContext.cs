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

            modelBuilder.Entity<Patient>().HasData(
                 new Patient
                 {
                     Id = Guid.Parse("b8879171-fab7-4342-8171-82b7900e6f4c"),
                     FirstName = "John",
                     LastName = "Doe",
                     Email = "john.doe@example.com",
                     Password = "password1",
                     BirthDate = new DateTime(1980, 1, 1),
                     Address = "123 Main St, Anytown, USA",
                     PhoneNumber = "123-456-7890",
                     Sex = Sex.Male
                 },
                 new Patient
                 {
                     Id = Guid.Parse("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                     FirstName = "Jane",
                     LastName = "Smith",
                     Email = "jane.smith@example.com",
                     Password = "password2",
                     BirthDate = new DateTime(1990, 2, 2),
                     Address = "456 Elm St, Othertown, USA",
                     PhoneNumber = "234-567-8901",
                     Sex = Sex.Female
                 }
             );

            modelBuilder.Entity<Notification>().HasData(
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Prescription,
                    Label = "Appointment Reminder",
                    Description = "Don't forget your appointment tomorrow at 10 AM.",
                    Date = DateTime.Now.AddDays(1),
                    Status = NotificationStatusEnum.Active,
                    DoctorId = Guid.Parse("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                    Duration = 30,
                    Regularity = "Once",
                    PatientId = Guid.Parse("b8879171-fab7-4342-8171-82b7900e6f4c")
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Appointment,
                    Label = "Medication Reminder",
                    Description = "Time to take your medication.",
                    Date = DateTime.Now.AddHours(6),
                    Status = NotificationStatusEnum.Rejected,
                    DoctorId = Guid.Parse("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                    Duration = 0,
                    Regularity = "Daily",
                    PatientId = Guid.Parse("b8879171-fab7-4342-8171-82b7900e6f4c")
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Prescription,
                    Label = "Lab Results",
                    Description = "Your recent lab results are ready for review.",
                    Date = DateTime.Now.AddDays(2),
                    Status = NotificationStatusEnum.Active,
                    DoctorId = Guid.Parse("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                    Duration = 0,
                    Regularity = "Once",
                    PatientId = Guid.Parse("b8879171-fab7-4342-8171-82b7900e6f4c")
                },
                new Notification
                {
                    Id = Guid.NewGuid(),
                    Type = NotificationTypeEnum.Appointment,
                    Label = "Follow-up Reminder",
                    Description = "Remember to schedule your follow-up appointment.",
                    Date = DateTime.Now.AddDays(7),
                    Status = NotificationStatusEnum.Pending,
                    DoctorId = Guid.Parse("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                    Duration = 0,
                    Regularity = "Once",
                    PatientId = Guid.Parse("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d")
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
                    Regularity = "Weekly",
                    PatientId = Guid.Parse("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d")
                }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = Guid.Parse("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
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