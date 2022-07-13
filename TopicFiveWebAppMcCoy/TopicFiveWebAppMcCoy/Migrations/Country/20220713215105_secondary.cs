using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicFiveWebAppMcCoy.Migrations.Country
{
    public partial class secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Categories_SportCategoryID",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "SportCategoryID",
                table: "Countries",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_SportCategoryID",
                table: "Countries",
                newName: "IX_Countries_CategoryID");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "austria",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "brazil",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "canada",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "china",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cyprus",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "finland",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "france",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "germany",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "greatBritain",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "italy",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jamaica",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "japan",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mexico",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "netherlands",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pakistan",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "portugal",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "russia",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "slovakia",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "sweden",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "thailand",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ukraine",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uruguay",
                column: "CategoryID",
                value: "indoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "usa",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zimbabwe",
                column: "CategoryID",
                value: "outdoor");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Categories_CategoryID",
                table: "Countries",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Categories_CategoryID",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Countries",
                newName: "SportCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                newName: "IX_Countries_SportCategoryID");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "austria",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "brazil",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "canada",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "china",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "cyprus",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "finland",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "france",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "germany",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "greatBritain",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "italy",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "jamaica",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "japan",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "mexico",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "netherlands",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "pakistan",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "portugal",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "russia",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "slovakia",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "sweden",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "thailand",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "ukraine",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "uruguay",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "usa",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: "zimbabwe",
                column: "SportCategoryID",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Categories_SportCategoryID",
                table: "Countries",
                column: "SportCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
