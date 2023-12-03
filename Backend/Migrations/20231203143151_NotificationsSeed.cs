using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class NotificationsSeed : Migration
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
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Doctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Regularity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
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
                    { new Guid("0453f113-0479-473b-bbd2-8fe2c2f66c93"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Jones" },
                    { new Guid("5b35ef66-ccaf-4fa5-9b0a-035a3154ccc7"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Green" },
                    { new Guid("6a152b96-7f5b-4b63-8f37-8c286cfd9acb"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. White" },
                    { new Guid("f35c1e12-b10c-405b-a035-93eee079572a"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Laura Garcia" },
                    { new Guid("f3f300d2-4dfb-405d-a925-aa16462d0939"), "vitalii.heorhiievskyi.pz.2020@lpnu.ua", "Dr. Smith" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Sex" },
                values: new object[,]
                {
                    { new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"), "456 Elm St, Othertown, USA", new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "password2", "234-567-8901", 1 },
                    { new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"), "123 Main St, Anytown, USA", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "password1", "123-456-7890", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PatientId",
                table: "Notifications",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7a47b2ab-1983-4c1f-b498-bf6b57fbb18d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b8879171-fab7-4342-8171-82b7900e6f4c"));
        }
    }
}
