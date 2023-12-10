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
                            Id = new Guid("43e47c67-ab67-4a94-8d6c-3b0cb1cc485b"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. White"
                        },
                        new
                        {
                            Id = new Guid("f9e4ae87-089c-48f5-9765-1cecff66f051"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Green"
                        },
                        new
                        {
                            Id = new Guid("0ca942b2-f6eb-4ced-9978-037e4d5f5532"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Jones"
                        },
                        new
                        {
                            Id = new Guid("c6391c8b-e34d-4937-8543-923515765fa9"),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            Name = "Dr. Laura Garcia"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b6aa887-b0e7-4e22-ba47-54b69a8806dc"),
                            Description = "Medical card with all needed info",
                            IsVerified = true,
                            Name = "Medical card",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            UploadDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Url = "No Url"
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

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5121fc54-6ef6-4fef-acc2-36219c557513"),
                            Date = new DateTime(2023, 12, 11, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(3955),
                            Description = "Don't forget your appointment tomorrow at 10 AM.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 30,
                            Label = "Appointment Reminder",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Regularity = "Once",
                            Status = "ACTIVE",
                            Type = "PRESCRIPTION"
                        },
                        new
                        {
                            Id = new Guid("ad6a137b-014c-4708-a7a8-42a79f7a041c"),
                            Date = new DateTime(2023, 12, 11, 3, 59, 56, 400, DateTimeKind.Local).AddTicks(3990),
                            Description = "Time to take your medication.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 0,
                            Label = "Medication Reminder",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Regularity = "Daily",
                            Status = "REJECTED",
                            Type = "APPOINTMENT"
                        },
                        new
                        {
                            Id = new Guid("65ae85fa-e9ea-4f29-afeb-7b0a4523f16d"),
                            Date = new DateTime(2023, 12, 12, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(3995),
                            Description = "Your recent lab results are ready for review.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 0,
                            Label = "Lab Results",
                            PatientId = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            Regularity = "Once",
                            Status = "ACTIVE",
                            Type = "PRESCRIPTION"
                        },
                        new
                        {
                            Id = new Guid("f0248789-3c4b-4c90-8198-2146aa10aa0e"),
                            Date = new DateTime(2023, 12, 17, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(4000),
                            Description = "Remember to schedule your follow-up appointment.",
                            DoctorId = new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"),
                            Duration = 0,
                            Label = "Follow-up Reminder",
                            PatientId = new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                            Regularity = "Once",
                            Status = "PENDING",
                            Type = "APPOINTMENT"
                        },
                        new
                        {
                            Id = new Guid("fe86f775-9a5e-4416-b70f-2f0953fb1544"),
                            Date = new DateTime(2023, 12, 13, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(4004),
                            Description = "Check out the latest health tips on our website.",
                            Duration = 0,
                            Label = "Health Tips",
                            PatientId = new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                            Regularity = "Weekly",
                            Status = "REJECTED",
                            Type = "PRESCRIPTION"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
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

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                            AddressId = new Guid("f04cd751-3fa2-4e73-86f4-a15ef896c7e6"),
                            DateOfBirth = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password1",
                            PhoneNumber = "123-456-7890",
                            Sex = "MALE"
                        },
                        new
                        {
                            Id = new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                            AddressId = new Guid("234208f7-43a3-4855-b01c-8dab74fdb46d"),
                            DateOfBirth = new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vitalii.heorhiievskyi.pz.2020@lpnu.ua",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Password = "password2",
                            PhoneNumber = "234-567-8901",
                            Sex = "FEMALE"
                        });
                });

            modelBuilder.Entity("WebApi.Models.PatientAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PatientAddresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f04cd751-3fa2-4e73-86f4-a15ef896c7e6"),
                            Address = "123 Main St",
                            City = "Anytown",
                            Country = "USA"
                        },
                        new
                        {
                            Id = new Guid("234208f7-43a3-4855-b01c-8dab74fdb46d"),
                            Address = "456 Elm St",
                            City = "Othertown",
                            Country = "USA"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Document", b =>
                {
                    b.HasOne("WebApi.Models.Patient", "Patient")
                        .WithMany("Documents")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
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
                    b.HasOne("WebApi.Models.PatientAddress", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WebApi.Models.Patient", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
