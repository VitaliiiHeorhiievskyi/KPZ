using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class NotificationsSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0453f113-0479-473b-bbd2-8fe2c2f66c93"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5b35ef66-ccaf-4fa5-9b0a-035a3154ccc7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6a152b96-7f5b-4b63-8f37-8c286cfd9acb"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f35c1e12-b10c-405b-a035-93eee079572a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f3f300d2-4dfb-405d-a925-aa16462d0939"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("315ddae6-c8c5-4594-9306-56ee3edb7610"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("4ea95ba4-277d-4c31-a6a2-660b5574dbe5"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("5c8ec3f3-7893-48b9-9701-3cd567c0d88b"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("90f3d21e-1516-4be1-9086-004aa4729f6e"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Smith" },
                    { new Guid("d2161032-8175-4981-b85c-882a8143c42f"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "Doctor", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("35565f6a-cb4d-4779-804a-1daf86983690"), new DateTime(2023, 12, 3, 22, 32, 18, 608, DateTimeKind.Local).AddTicks(8739), "Time to take your medication.", "Dr. Jones", 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", 1, 0 },
                    { new Guid("a2aaaf9e-7ad1-4506-ae90-994450faba0f"), new DateTime(2023, 12, 10, 16, 32, 18, 608, DateTimeKind.Local).AddTicks(8747), "Remember to schedule your follow-up appointment.", "Dr. White", 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", 0, 0 },
                    { new Guid("a8c87ed1-3472-4755-bb14-04cb7211adcb"), new DateTime(2023, 12, 6, 16, 32, 18, 608, DateTimeKind.Local).AddTicks(8750), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", 1, 1 },
                    { new Guid("bafade32-6d43-4538-9d3a-50ef146dc0cc"), new DateTime(2023, 12, 5, 16, 32, 18, 608, DateTimeKind.Local).AddTicks(8743), "Your recent lab results are ready for review.", "Dr. Green", 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("f012bdb1-e9f0-4bd7-8704-cf1a9f19d1f9"), new DateTime(2023, 12, 4, 16, 32, 18, 608, DateTimeKind.Local).AddTicks(8702), "Don't forget your appointment tomorrow at 10 AM.", "Dr. Smith", 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("315ddae6-c8c5-4594-9306-56ee3edb7610"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4ea95ba4-277d-4c31-a6a2-660b5574dbe5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5c8ec3f3-7893-48b9-9701-3cd567c0d88b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("90f3d21e-1516-4be1-9086-004aa4729f6e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d2161032-8175-4981-b85c-882a8143c42f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("35565f6a-cb4d-4779-804a-1daf86983690"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("a2aaaf9e-7ad1-4506-ae90-994450faba0f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("a8c87ed1-3472-4755-bb14-04cb7211adcb"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("bafade32-6d43-4538-9d3a-50ef146dc0cc"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("f012bdb1-e9f0-4bd7-8704-cf1a9f19d1f9"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("0453f113-0479-473b-bbd2-8fe2c2f66c93"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("5b35ef66-ccaf-4fa5-9b0a-035a3154ccc7"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("6a152b96-7f5b-4b63-8f37-8c286cfd9acb"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("f35c1e12-b10c-405b-a035-93eee079572a"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f3f300d2-4dfb-405d-a925-aa16462d0939"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Smith" }
                });
        }
    }
}
