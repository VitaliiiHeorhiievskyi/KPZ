using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddDocument : Migration
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
                    { new Guid("5c9c61dd-5f36-446f-a4b5-a4395ef2787b"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("b40930dd-49db-4e62-aeb9-0be4809becb4"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("b6d6e9ce-32a6-49fa-9a78-a0c96dfbe5a1"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("e921f5a3-08cf-46bb-9315-bdfa5938a53a"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "Duration", "Label", "PatientId", "Regularity", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("260df0ed-2662-497b-8730-5f60856bc7f9"), new DateTime(2023, 12, 4, 17, 1, 35, 61, DateTimeKind.Local).AddTicks(1772), "Don't forget your appointment tomorrow at 10 AM.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 30, "Appointment Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("32b4acd7-b0d1-4156-a77d-3b871c70074e"), new DateTime(2023, 12, 10, 17, 1, 35, 61, DateTimeKind.Local).AddTicks(1833), "Remember to schedule your follow-up appointment.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Follow-up Reminder", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Once", 0, 0 },
                    { new Guid("41b1f610-3fc2-42d7-85a5-fc3894baea8c"), new DateTime(2023, 12, 5, 17, 1, 35, 61, DateTimeKind.Local).AddTicks(1825), "Your recent lab results are ready for review.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Lab Results", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Once", 2, 1 },
                    { new Guid("5ddf3f92-d650-420e-af0f-133090dec775"), new DateTime(2023, 12, 3, 23, 1, 35, 61, DateTimeKind.Local).AddTicks(1818), "Time to take your medication.", new Guid("402d2cc4-1ef7-46e2-a047-1774647ffcf8"), 0, "Medication Reminder", new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "Daily", 1, 0 },
                    { new Guid("b6026409-6370-4131-a6c9-d75e2fac48fa"), new DateTime(2023, 12, 6, 17, 1, 35, 61, DateTimeKind.Local).AddTicks(1839), "Check out the latest health tips on our website.", null, 0, "Health Tips", new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "Weekly", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Sex" },
                values: new object[] { new Guid("784fe36b-4aaf-4430-bbea-2089f81b753b"), "123 Main St", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "hashed_password", "123-456-7890", 0 });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Description", "IsVerified", "Name", "PatientId", "UploadDate", "Url" },
                values: new object[] { new Guid("a1e064dc-c716-4380-9d47-ed632a2c0a64"), "Medical card with all needed info", true, "Medical card", new Guid("784fe36b-4aaf-4430-bbea-2089f81b753b"), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Url" });

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
                keyValue: new Guid("5c9c61dd-5f36-446f-a4b5-a4395ef2787b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b40930dd-49db-4e62-aeb9-0be4809becb4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b6d6e9ce-32a6-49fa-9a78-a0c96dfbe5a1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e921f5a3-08cf-46bb-9315-bdfa5938a53a"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("260df0ed-2662-497b-8730-5f60856bc7f9"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("32b4acd7-b0d1-4156-a77d-3b871c70074e"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("41b1f610-3fc2-42d7-85a5-fc3894baea8c"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("5ddf3f92-d650-420e-af0f-133090dec775"));

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: new Guid("b6026409-6370-4131-a6c9-d75e2fac48fa"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("784fe36b-4aaf-4430-bbea-2089f81b753b"));

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
        }
    }
}
