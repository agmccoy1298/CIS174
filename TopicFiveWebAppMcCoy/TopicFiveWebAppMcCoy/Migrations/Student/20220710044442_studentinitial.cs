using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicFiveWebAppMcCoy.Migrations.Student
{
    public partial class studentinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentList",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentList", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "StudentList",
                columns: new[] { "StudentID", "FirstName", "Grade", "LastName" },
                values: new object[,]
                {
                    { 1, "Andrew", "D+", "McCoy" },
                    { 2, "Liam", "C+", "Hemsworth" },
                    { 3, "Daniel", "A-", "Smith" },
                    { 4, "Anna", "B+", "Cox" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentList");
        }
    }
}
