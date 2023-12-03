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
                            Id = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Smith"
                        },
                        new
                        {
                            Id = new Guid("f83fd5cd-f6eb-42c0-928b-ce9ad121e0d4"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. White"
                        },
                        new
                        {
                            Id = new Guid("3e00a3d2-9137-4d51-9d0d-ee8a4bbccbc6"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Green"
                        },
                        new
                        {
                            Id = new Guid("33860d65-b6bd-4392-b2cf-b477369fed6a"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Jones"
                        },
                        new
                        {
                            Id = new Guid("e01f7dc5-9252-4db8-9483-744b0357fd84"),
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

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Regularity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = new Guid("957570eb-485c-46bd-b56e-1638d7d9edf9"),
                            Date = new DateTime(2023, 12, 4, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6333),
                            Description = "Don't forget your appointment tomorrow at 10 AM.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 30,
                            Label = "Appointment Reminder",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Regularity = "Once",
                            Status = 2,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("a478278e-f282-4104-ade8-23c4f28bb971"),
                            Date = new DateTime(2023, 12, 3, 22, 35, 56, 616, DateTimeKind.Local).AddTicks(6370),
                            Description = "Time to take your medication.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 0,
                            Label = "Medication Reminder",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Regularity = "Daily",
                            Status = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d9c8509b-d4fb-43e9-8d6d-5d3b90b61782"),
                            Date = new DateTime(2023, 12, 5, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6375),
                            Description = "Your recent lab results are ready for review.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 0,
                            Label = "Lab Results",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Regularity = "Once",
                            Status = 2,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("9d1b1cf1-4386-4b4c-b380-db08bc7d5d1f"),
                            Date = new DateTime(2023, 12, 10, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6379),
                            Description = "Remember to schedule your follow-up appointment.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 0,
                            Label = "Follow-up Reminder",
                            PatientId = new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                            Regularity = "Once",
                            Status = 0,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("8b50155d-ff86-48fc-8f99-a710a46cf570"),
                            Date = new DateTime(2023, 12, 6, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6384),
                            Description = "Check out the latest health tips on our website.",
                            Duration = 0,
                            Label = "Health Tips",
                            PatientId = new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Address = "123 Main St, Anytown, USA",
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password1",
                            PhoneNumber = "123-456-7890",
                            Sex = 0
                        },
                        new
                        {
                            Id = new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                            Address = "456 Elm St, Othertown, USA",
                            BirthDate = new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "georgiievsky@gmail.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Password = "password2",
                            PhoneNumber = "234-567-8901",
                            Sex = 1
                        });
                });

            modelBuilder.Entity("WebApi.Models.Notification", b =>
                {
                    b.HasOne("WebApi.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("WebApi.Models.Patient", "Patient")
                        .WithMany("Notifications")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("WebApi.Models.Patient", b =>
                {
                    b.Navigation("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
