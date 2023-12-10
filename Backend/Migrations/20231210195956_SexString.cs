using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class SexString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("0ca942b2-f6eb-4ced-9978-037e4d5f5532"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("43e47c67-ab67-4a94-8d6c-3b0cb1cc485b"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("c6391c8b-e34d-4937-8543-923515765fa9"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f9e4ae87-089c-48f5-9765-1cecff66f051"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "IsVerified", "Name", "PatientId", "UploadDate", "Url" },
                values: new object[] { new Guid("1b6aa887-b0e7-4e22-ba47-54b69a8806dc"), "Medical card with all needed info", true, "Medical card", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Url" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("5121fc54-6ef6-4fef-acc2-36219c557513"), new DateTime(2023, 12, 11, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(3955), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", "ACTIVE", "PRESCRIPTION" },
                    { new Guid("65ae85fa-e9ea-4f29-afeb-7b0a4523f16d"), new DateTime(2023, 12, 12, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(3995), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", "ACTIVE", "PRESCRIPTION" },
                    { new Guid("ad6a137b-014c-4708-a7a8-42a79f7a041c"), new DateTime(2023, 12, 11, 3, 59, 56, 400, DateTimeKind.Local).AddTicks(3990), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", "REJECTED", "APPOINTMENT" },
                    { new Guid("f0248789-3c4b-4c90-8198-2146aa10aa0e"), new DateTime(2023, 12, 17, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(4000), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", "PENDING", "APPOINTMENT" },
                    { new Guid("fe86f775-9a5e-4416-b70f-2f0953fb1544"), new DateTime(2023, 12, 13, 21, 59, 56, 400, DateTimeKind.Local).AddTicks(4004), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", "REJECTED", "PRESCRIPTION" }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                columns: new[] { "Email", "Sex" },
                values: new object[] { "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "FEMALE" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                columns: new[] { "Email", "Sex" },
                values: new object[] { "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "MALE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0ca942b2-f6eb-4ced-9978-037e4d5f5532"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("43e47c67-ab67-4a94-8d6c-3b0cb1cc485b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c6391c8b-e34d-4937-8543-923515765fa9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f9e4ae87-089c-48f5-9765-1cecff66f051"));

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: new Guid("1b6aa887-b0e7-4e22-ba47-54b69a8806dc"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("5121fc54-6ef6-4fef-acc2-36219c557513"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("65ae85fa-e9ea-4f29-afeb-7b0a4523f16d"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("ad6a137b-014c-4708-a7a8-42a79f7a041c"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("f0248789-3c4b-4c90-8198-2146aa10aa0e"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("fe86f775-9a5e-4416-b70f-2f0953fb1544"));

            migrationBuilder.AlterColumn<int>(
                name: "Sex",
                table: "Patients",
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

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                columns: new[] { "Email", "Sex" },
                values: new object[] { "jane.smith@example.com", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"),
                columns: new[] { "Email", "Sex" },
                values: new object[] { "john.doe@example.com", 0 });
        }
    }
}
