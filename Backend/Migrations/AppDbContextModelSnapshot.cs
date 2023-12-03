﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientHealth.DataBase;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6dceef30-76fb-43e3-9e19-652f51708291"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Smith"
                        },
                        new
                        {
                            Id = new Guid("974de7f2-bd3c-4a2f-9a0f-a8133b79641c"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. White"
                        },
                        new
                        {
                            Id = new Guid("d402bac3-cb64-4168-9570-2e92d257623e"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Green"
                        },
                        new
                        {
                            Id = new Guid("7b7711ac-8ebc-4633-befd-10d8841b4009"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Jones"
                        },
                        new
                        {
                            Id = new Guid("bd6c0d10-2fbf-4e4d-bf6f-0231a62027d8"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Laura Garcia"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regularity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4bc17de2-e8e2-4aff-97c1-e823dd8fd142"),
                            Date = new DateTime(2023, 12, 4, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6893),
                            Description = "Don't forget your appointment tomorrow at 10 AM.",
                            Doctor = "Dr. Smith",
                            Duration = 30,
                            Label = "Appointment Reminder",
                            Regularity = "Once",
                            Status = 2,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("5cd61a03-f955-4fea-a58b-eaca70f9cec3"),
                            Date = new DateTime(2023, 12, 3, 22, 8, 16, 406, DateTimeKind.Local).AddTicks(6926),
                            Description = "Time to take your medication.",
                            Doctor = "Dr. Jones",
                            Duration = 0,
                            Label = "Medication Reminder",
                            Regularity = "Daily",
                            Status = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("6c76b372-483d-4d01-a774-695f742fecbc"),
                            Date = new DateTime(2023, 12, 5, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6929),
                            Description = "Your recent lab results are ready for review.",
                            Doctor = "Dr. Green",
                            Duration = 0,
                            Label = "Lab Results",
                            Regularity = "Once",
                            Status = 2,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("709ac1f6-4e92-467d-be82-819478a57723"),
                            Date = new DateTime(2023, 12, 10, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6932),
                            Description = "Remember to schedule your follow-up appointment.",
                            Doctor = "Dr. White",
                            Duration = 0,
                            Label = "Follow-up Reminder",
                            Regularity = "Once",
                            Status = 0,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d2c46ede-5ee2-4e26-9fd4-5de3d152701f"),
                            Date = new DateTime(2023, 12, 6, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6936),
                            Description = "Check out the latest health tips on our website.",
                            Duration = 0,
                            Label = "Health Tips",
                            Regularity = "Weekly",
                            Status = 1,
                            Type = 1
                        });
                });

            modelBuilder.Entity("WebApi.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
