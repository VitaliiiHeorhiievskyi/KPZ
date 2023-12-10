using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_PatientAddresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "PatientAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Regularity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("0525b1ad-522f-4a95-9558-9b6081d18276"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("0b196069-df22-44b0-8fc3-1e1b5c96e691"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Smith" },
                    { new Guid("8a879600-b02a-4bc7-8d1b-8e6292d6a2c4"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f758ed87-5ba4-4cd7-a65a-30b3de7c0427"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" }
                });

            migrationBuilder.InsertData(
                table: "PatientAddresses",
                columns: new[] { "Id", "Address", "City", "Country" },
                values: new object[,]
                {
                    { new Guid("234208f7-43a3-4855-b01c-8dab74fdb46d"), "456 Elm St", "Othertown", "USA" },
                    { new Guid("f04cd751-3fa2-4e73-86f4-a15ef896c7e6"), "123 Main St", "Anytown", "USA" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AddressId", "DateOfBirth", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Sex" },
                values: new object[] { new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), new Guid("234208f7-43a3-4855-b01c-8dab74fdb46d"), new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "password2", "234-567-8901", 1 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AddressId", "DateOfBirth", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Sex" },
                values: new object[] { new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), new Guid("f04cd751-3fa2-4e73-86f4-a15ef896c7e6"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "password1", "123-456-7890", 0 });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "IsVerified", "Name", "PatientId", "UploadDate", "Url" },
                values: new object[] { new Guid("56ad852a-7bc1-46dd-9fc1-7bd271c808d7"), "Medical card with all needed info", true, "Medical card", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Url" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("58970d98-334b-4588-a77e-b29ed52a2b9f"), new DateTime(2023, 12, 13, 20, 15, 57, 573, DateTimeKind.Local).AddTicks(6843), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", 1, 1 },
                    { new Guid("77c0f521-462d-41a7-b7ed-2900ab159b6f"), new DateTime(2023, 12, 12, 20, 15, 57, 573, DateTimeKind.Local).AddTicks(6835), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("9ba5a97d-0f33-40e3-947f-e088bd2d04c2"), new DateTime(2023, 12, 11, 20, 15, 57, 573, DateTimeKind.Local).AddTicks(6797), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("a282b967-7f21-4c51-a981-6f8cbecbaaff"), new DateTime(2023, 12, 17, 20, 15, 57, 573, DateTimeKind.Local).AddTicks(6839), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", 0, 0 },
                    { new Guid("f90bf836-d3fc-426d-8655-ddf454729ee2"), new DateTime(2023, 12, 11, 2, 15, 57, 573, DateTimeKind.Local).AddTicks(6830), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PatientId",
                table: "Documents",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_DoctorId",
                table: "Notifications",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PatientId",
                table: "Notifications",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AddressId",
                table: "Patients",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PatientAddresses");
        }
    }
}
