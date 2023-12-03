using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class NotificationsSeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("30099474-3010-4e9f-a6c2-cc7af97746fb"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("52b22119-f91b-4e27-8926-407c6e0c5c41"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("87597d6b-6c12-414b-8428-fbc499906ec9"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("aae82102-4c76-447f-88e7-7f2ae0ed06a2"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("cd8d3970-2eda-48bc-a4d1-805f123cc316"));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "Doctor", "Duration", "Label", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("22ad025a-28d9-42ed-895c-bdbe66c34571"), new DateTime(2023, 12, 3, 21, 34, 54, 106, DateTimeKind.Local).AddTicks(4855), "Time to take your medication.", "Dr. Jones", 0, "Medication Reminder", "Daily", 1, 0 },
                    { new Guid("80b9a465-e7ae-41e6-8b79-684d30a19340"), new DateTime(2023, 12, 4, 15, 34, 54, 106, DateTimeKind.Local).AddTicks(4812), "Don't forget your appointment tomorrow at 10 AM.", "Dr. Smith", 30, "Appointment Reminder", "Once", 2, 1 },
                    { new Guid("8e346e53-2937-4a3e-af60-50070f47e6d7"), new DateTime(2023, 12, 5, 15, 34, 54, 106, DateTimeKind.Local).AddTicks(4859), "Your recent lab results are ready for review.", "Dr. Green", 0, "Lab Results", "Once", 2, 1 },
                    { new Guid("9c61f6ea-4a26-4837-adbd-81cd349f62f1"), new DateTime(2023, 12, 6, 15, 34, 54, 106, DateTimeKind.Local).AddTicks(4868), "Check out the latest health tips on our website.", null, 0, "Health Tips", "Weekly", 1, 1 },
                    { new Guid("a38d9124-0915-4323-aa6b-a671e481832f"), new DateTime(2023, 12, 10, 15, 34, 54, 106, DateTimeKind.Local).AddTicks(4864), "Remember to schedule your follow-up appointment.", "Dr. White", 0, "Follow-up Reminder", "Once", 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("22ad025a-28d9-42ed-895c-bdbe66c34571"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("80b9a465-e7ae-41e6-8b79-684d30a19340"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("8e346e53-2937-4a3e-af60-50070f47e6d7"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("9c61f6ea-4a26-4837-adbd-81cd349f62f1"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("a38d9124-0915-4323-aa6b-a671e481832f"));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "Doctor", "Duration", "Label", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("30099474-3010-4e9f-a6c2-cc7af97746fb"), new DateTime(2023, 12, 6, 15, 4, 22, 509, DateTimeKind.Local).AddTicks(1027), "Check out the latest health tips on our website.", null, 0, "Health Tips", "Weekly", 1, 1 },
                    { new Guid("52b22119-f91b-4e27-8926-407c6e0c5c41"), new DateTime(2023, 12, 4, 15, 4, 22, 509, DateTimeKind.Local).AddTicks(951), "Don't forget your appointment tomorrow at 10 AM.", "Dr. Smith", 30, "Appointment Reminder", "Once", 3, 1 },
                    { new Guid("87597d6b-6c12-414b-8428-fbc499906ec9"), new DateTime(2023, 12, 3, 21, 4, 22, 509, DateTimeKind.Local).AddTicks(989), "Time to take your medication.", "Dr. Jones", 0, "Medication Reminder", "Daily", 2, 0 },
                    { new Guid("aae82102-4c76-447f-88e7-7f2ae0ed06a2"), new DateTime(2023, 12, 10, 15, 4, 22, 509, DateTimeKind.Local).AddTicks(996), "Remember to schedule your follow-up appointment.", "Dr. White", 0, "Follow-up Reminder", "Once", 0, 0 },
                    { new Guid("cd8d3970-2eda-48bc-a4d1-805f123cc316"), new DateTime(2023, 12, 5, 15, 4, 22, 509, DateTimeKind.Local).AddTicks(993), "Your recent lab results are ready for review.", "Dr. Green", 0, "Lab Results", "Once", 3, 1 }
                });
        }
    }
}
