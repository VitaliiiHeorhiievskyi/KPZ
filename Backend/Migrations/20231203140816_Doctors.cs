using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Doctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("6dceef30-76fb-43e3-9e19-652f51708291"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Smith" },
                    { new Guid("7b7711ac-8ebc-4633-befd-10d8841b4009"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("974de7f2-bd3c-4a2f-9a0f-a8133b79641c"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("bd6c0d10-2fbf-4e4d-bf6f-0231a62027d8"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("d402bac3-cb64-4168-9570-2e92d257623e"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "Doctor", "Duration", "Label", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("4bc17de2-e8e2-4aff-97c1-e823dd8fd142"), new DateTime(2023, 12, 4, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6893), "Don't forget your appointment tomorrow at 10 AM.", "Dr. Smith", 30, "Appointment Reminder", "Once", 2, 1 },
                    { new Guid("5cd61a03-f955-4fea-a58b-eaca70f9cec3"), new DateTime(2023, 12, 3, 22, 8, 16, 406, DateTimeKind.Local).AddTicks(6926), "Time to take your medication.", "Dr. Jones", 0, "Medication Reminder", "Daily", 1, 0 },
                    { new Guid("6c76b372-483d-4d01-a774-695f742fecbc"), new DateTime(2023, 12, 5, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6929), "Your recent lab results are ready for review.", "Dr. Green", 0, "Lab Results", "Once", 2, 1 },
                    { new Guid("709ac1f6-4e92-467d-be82-819478a57723"), new DateTime(2023, 12, 10, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6932), "Remember to schedule your follow-up appointment.", "Dr. White", 0, "Follow-up Reminder", "Once", 0, 0 },
                    { new Guid("d2c46ede-5ee2-4e26-9fd4-5de3d152701f"), new DateTime(2023, 12, 6, 16, 8, 16, 406, DateTimeKind.Local).AddTicks(6936), "Check out the latest health tips on our website.", null, 0, "Health Tips", "Weekly", 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("4bc17de2-e8e2-4aff-97c1-e823dd8fd142"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("5cd61a03-f955-4fea-a58b-eaca70f9cec3"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("6c76b372-483d-4d01-a774-695f742fecbc"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("709ac1f6-4e92-467d-be82-819478a57723"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("d2c46ede-5ee2-4e26-9fd4-5de3d152701f"));

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
    }
}
