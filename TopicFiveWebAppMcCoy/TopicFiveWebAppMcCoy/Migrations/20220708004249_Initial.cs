using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicFiveWebAppMcCoy.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "ClassName", "Name" },
                values: new object[] { 1, "Advanced C#", "Unit 3" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "ClassName", "Name" },
                values: new object[] { 2, "CIS Internship", "Testing" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "ClassName", "Name" },
                values: new object[] { 3, "Data Science 1", "Week 4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");
        }
    }
}
