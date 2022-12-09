using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class InitDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FullDescription = table.Column<string>(name: "Full Description", type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CreatedDate", "Full Description", "Name", "Priority", "Status" },
                values: new object[] { 1, new DateTime(2022, 12, 9, 14, 33, 57, 66, DateTimeKind.Local).AddTicks(3165), "New", "Number 1", 1, 0 });

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CreatedDate", "Full Description", "Name", "Priority", "Status" },
                values: new object[] { 2, new DateTime(2022, 12, 9, 14, 33, 57, 66, DateTimeKind.Local).AddTicks(3206), "In progress", "Number 2", 2, 1 });

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CreatedDate", "Full Description", "Name", "Priority", "Status" },
                values: new object[] { 3, new DateTime(2022, 12, 9, 14, 33, 57, 66, DateTimeKind.Local).AddTicks(3208), "Closed", "Number 3", 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTasks");
        }
    }
}
