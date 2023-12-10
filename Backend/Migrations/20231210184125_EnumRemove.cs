using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class EnumRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0525b1ad-522f-4a95-9558-9b6081d18276"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0b196069-df22-44b0-8fc3-1e1b5c96e691"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8a879600-b02a-4bc7-8d1b-8e6292d6a2c4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f758ed87-5ba4-4cd7-a65a-30b3de7c0427"));

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: new Guid("56ad852a-7bc1-46dd-9fc1-7bd271c808d7"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("58970d98-334b-4588-a77e-b29ed52a2b9f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("77c0f521-462d-41a7-b7ed-2900ab159b6f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("9ba5a97d-0f33-40e3-947f-e088bd2d04c2"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("a282b967-7f21-4c51-a981-6f8cbecbaaff"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("f90bf836-d3fc-426d-8655-ddf454729ee2"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("492b15af-940d-46b5-b1c3-b26d8f39dbce"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("67927bcc-2d9e-4e6c-b648-b2de80c57aaa"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("a0f3553e-79c9-4f7d-9b49-b75a28b660ff"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("aa9ba29d-f966-45cc-a246-dcd996e27b55"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "IsVerified", "Name", "PatientId", "UploadDate", "Url" },
                values: new object[] { new Guid("adea6f5d-1ad8-48c6-9eb3-353bd45f48d1"), "Medical card with all needed info", true, "Medical card", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Url" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("06a17de2-4f0a-47f0-8340-68e46a4e9c00"), new DateTime(2023, 12, 11, 20, 41, 24, 823, DateTimeKind.Local).AddTicks(1759), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", "ACTIVE", "PRESCRIPTION" },
                    { new Guid("31715aca-f93b-436c-a1b7-3ef8b89e453b"), new DateTime(2023, 12, 11, 2, 41, 24, 823, DateTimeKind.Local).AddTicks(1797), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", "REJECTED", "APPOINTMENT" },
                    { new Guid("462a3cf7-a79e-4dd9-b4de-c9994ab80bab"), new DateTime(2023, 12, 17, 20, 41, 24, 823, DateTimeKind.Local).AddTicks(1806), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", "PENDING", "APPOINTMENT" },
                    { new Guid("ecf6bde1-a708-4dbb-8678-08bf168019c1"), new DateTime(2023, 12, 12, 20, 41, 24, 823, DateTimeKind.Local).AddTicks(1802), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", "ACTIVE", "PRESCRIPTION" },
                    { new Guid("eda713d1-a1a6-4c07-a1a5-43248b7b0e87"), new DateTime(2023, 12, 13, 20, 41, 24, 823, DateTimeKind.Local).AddTicks(1811), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", "REJECTED", "PRESCRIPTION" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("492b15af-940d-46b5-b1c3-b26d8f39dbce"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("67927bcc-2d9e-4e6c-b648-b2de80c57aaa"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a0f3553e-79c9-4f7d-9b49-b75a28b660ff"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("aa9ba29d-f966-45cc-a246-dcd996e27b55"));

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: new Guid("adea6f5d-1ad8-48c6-9eb3-353bd45f48d1"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("06a17de2-4f0a-47f0-8340-68e46a4e9c00"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("31715aca-f93b-436c-a1b7-3ef8b89e453b"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("462a3cf7-a79e-4dd9-b4de-c9994ab80bab"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("ecf6bde1-a708-4dbb-8678-08bf168019c1"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("eda713d1-a1a6-4c07-a1a5-43248b7b0e87"));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("0525b1ad-522f-4a95-9558-9b6081d18276"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("0b196069-df22-44b0-8fc3-1e1b5c96e691"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("8a879600-b02a-4bc7-8d1b-8e6292d6a2c4"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f758ed87-5ba4-4cd7-a65a-30b3de7c0427"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" }
                });

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
        }
    }
}
