using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class MakePatientOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("77dfc1c2-8d0e-417c-8f9c-1c595ea155a4"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("b41880a2-6e22-4b52-bc02-781e9a4fe534"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("b4921fbe-27c9-4089-a831-5e429f72e973"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("b8904758-a99f-44f1-bc1f-cac0b8c482d8"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "IsVerified", "Name", "PatientId", "UploadDate", "Url" },
                values: new object[] { new Guid("0542d634-8231-4f56-a12e-aa34c713d718"), "Medical card with all needed info", true, "Medical card", new Guid("784fe36b-4aaf-4430-bbea-2089f81b753b"), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Url" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("05328dff-4c5c-4d84-83d7-3c74ca8a5067"), new DateTime(2023, 12, 3, 23, 23, 11, 732, DateTimeKind.Local).AddTicks(7643), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", 1, 0 },
                    { new Guid("099801e9-ca85-4232-bcd6-cfc3135c46bb"), new DateTime(2023, 12, 4, 17, 23, 11, 732, DateTimeKind.Local).AddTicks(7580), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("4505b0ca-8d55-420c-9052-b483335ed482"), new DateTime(2023, 12, 6, 17, 23, 11, 732, DateTimeKind.Local).AddTicks(7676), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", 1, 1 },
                    { new Guid("65eb8da2-f262-4753-baaf-9f0181484365"), new DateTime(2023, 12, 5, 17, 23, 11, 732, DateTimeKind.Local).AddTicks(7655), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("d7789c60-c51f-4b9c-9a7a-f3c1ecbafcf3"), new DateTime(2023, 12, 10, 17, 23, 11, 732, DateTimeKind.Local).AddTicks(7666), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                column: "Email",
                value: "jane.smith@example.com");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PatientId",
                table: "Documents",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("77dfc1c2-8d0e-417c-8f9c-1c595ea155a4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b41880a2-6e22-4b52-bc02-781e9a4fe534"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b4921fbe-27c9-4089-a831-5e429f72e973"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b8904758-a99f-44f1-bc1f-cac0b8c482d8"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("05328dff-4c5c-4d84-83d7-3c74ca8a5067"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("099801e9-ca85-4232-bcd6-cfc3135c46bb"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("4505b0ca-8d55-420c-9052-b483335ed482"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("65eb8da2-f262-4753-baaf-9f0181484365"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("d7789c60-c51f-4b9c-9a7a-f3c1ecbafcf3"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("33860d65-b6bd-4392-b2cf-b477369fed6a"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("3e00a3d2-9137-4d51-9d0d-ee8a4bbccbc6"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("e01f7dc5-9252-4db8-9483-744b0357fd84"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f83fd5cd-f6eb-42c0-928b-ce9ad121e0d4"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("8b50155d-ff86-48fc-8f99-a710a46cf570"), new DateTime(2023, 12, 6, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6384), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", 1, 1 },
                    { new Guid("957570eb-485c-46bd-b56e-1638d7d9edf9"), new DateTime(2023, 12, 4, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6333), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("9d1b1cf1-4386-4b4c-b380-db08bc7d5d1f"), new DateTime(2023, 12, 10, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6379), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", 0, 0 },
                    { new Guid("a478278e-f282-4104-ade8-23c4f28bb971"), new DateTime(2023, 12, 3, 22, 35, 56, 616, DateTimeKind.Local).AddTicks(6370), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", 1, 0 },
                    { new Guid("d9c8509b-d4fb-43e9-8d6d-5d3b90b61782"), new DateTime(2023, 12, 5, 16, 35, 56, 616, DateTimeKind.Local).AddTicks(6375), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"),
                column: "Email",
                value: "georgiievsky@gmail.com");
        }
    }
}
