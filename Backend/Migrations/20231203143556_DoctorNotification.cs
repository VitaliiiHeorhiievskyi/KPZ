using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class DoctorNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Notifications");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Notifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("33860d65-b6bd-4392-b2cf-b477369fed6a"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("3e00a3d2-9137-4d51-9d0d-ee8a4bbccbc6"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Smith" },
                    { new Guid("e01f7dc5-9252-4db8-9483-744b0357fd84"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f83fd5cd-f6eb-42c0-928b-ce9ad121e0d4"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[] { new Guid("8b50155d-ff86-48fc-8f99-a710a46cf570"), new DateTime(2023, 12, 6, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6384), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", 1, 1 });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("957570eb-485c-46bd-b56e-1638d7d9edf9"), new DateTime(2023, 12, 4, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6333), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("9d1b1cf1-4386-4b4c-b380-db08bc7d5d1f"), new DateTime(2023, 12, 10, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6379), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", 0, 0 },
                    { new Guid("a478278e-f282-4104-ade8-23c4f28bb971"), new DateTime(2023, 12, 3, 22, 35, 56, 616, DateTimeKind.Local).AddTicks(6370), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", 1, 0 },
                    { new Guid("d9c8509b-d4fb-43e9-8d6d-5d3b90b61782"), new DateTime(2023, 12, 5, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6375), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_DoctorId",
                table: "Notifications",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Doctors_DoctorId",
                table: "Notifications",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Doctors_DoctorId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_DoctorId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("33860d65-b6bd-4392-b2cf-b477369fed6a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3e00a3d2-9137-4d51-9d0d-ee8a4bbccbc6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e01f7dc5-9252-4db8-9483-744b0357fd84"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f83fd5cd-f6eb-42c0-928b-ce9ad121e0d4"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("8b50155d-ff86-48fc-8f99-a710a46cf570"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("957570eb-485c-46bd-b56e-1638d7d9edf9"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("9d1b1cf1-4386-4b4c-b380-db08bc7d5d1f"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("a478278e-f282-4104-ade8-23c4f28bb971"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("d9c8509b-d4fb-43e9-8d6d-5d3b90b61782"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"));

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Notifications");

            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}