using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicFiveWebAppMcCoy.Migrations.Country
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_SportCategoryID",
                        column: x => x.SportCategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "winter", "Winter Olympics" },
                    { "summer", "Summer Olympics" },
                    { "paralympics", "Paralympics" },
                    { "youth", "Youth Olymic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "FlagImage", "GameID", "Name", "SportCategoryID" },
                values: new object[,]
                {
                    { "canada", "https://www.worldometers.info/img/flags/small/tn_ca-flag.gif", "winter", "Canada", null },
                    { "finland", "https://www.worldometers.info/img/flags/small/tn_fi-flag.gif", "youth", "Finland", null },
                    { "russia", "https://www.worldometers.info/img/flags/small/tn_rs-flag.gif", "youth", "Russia", null },
                    { "cyprus", "https://www.worldometers.info/img/flags/small/tn_cy-flag.gif", "youth", "Cyprus", null },
                    { "france", "https://www.worldometers.info/img/flags/small/tn_fr-flag.gif", "youth", "France", null },
                    { "zimbabwe", "https://www.worldometers.info/img/flags/small/tn_zi-flag.gif", "paralympics", "Zimbabwe", null },
                    { "pakistan", "https://www.worldometers.info/img/flags/small/tn_pk-flag.gif", "paralympics", "Pakistan", null },
                    { "austria", "https://www.worldometers.info/img/flags/small/tn_au-flag.gif", "paralympics", "Austria", null },
                    { "ukraine", "https://www.worldometers.info/img/flags/small/tn_up-flag.gif", "paralympics", "Ukraine", null },
                    { "uruguay", "https://www.worldometers.info/img/flags/small/tn_uy-flag.gif", "paralympics", "Uruguay", null },
                    { "thailand", "https://www.worldometers.info/img/flags/small/tn_th-flag.gif", "paralympics", "Thailand", null },
                    { "usa", "https://www.worldometers.info/img/flags/small/tn_us-flag.gif", "summer", "USA", null },
                    { "netherlands", "https://www.worldometers.info/img/flags/small/tn_nl-flag.gif", "summer", "Netherlands", null },
                    { "brazil", "https://www.worldometers.info/img/flags/small/tn_br-flag.gif", "summer", "Brazil", null },
                    { "mexico", "https://www.worldometers.info/img/flags/small/tn_mx-flag.gif-", "summer", "Mexico", null },
                    { "china", "https://www.worldometers.info/img/flags/small/tn_ch-flag.gif", "summer", "China", null },
                    { "germany", "https://www.worldometers.info/img/flags/small/tn_gm-flag.gif", "summer", "Germany", null },
                    { "japan", "https://www.worldometers.info/img/flags/small/tn_ja-flag.gif", "winter", "Japan", null },
                    { "italy", "https://www.worldometers.info/img/flags/small/tn_it-flag.gif", "winter", "Italy", null },
                    { "jamaica", "https://www.worldometers.info/img/flags/small/tn_jm-flag.gif", "winter", "Jamaica", null },
                    { "greatBritain", "https://www.worldometers.info/img/flags/small/tn_uk-flag.gif", "winter", "Great Britain", null },
                    { "sweden", "https://www.worldometers.info/img/flags/small/tn_sw-flag.gif", "winter", "Sweden", null },
                    { "slovakia", "https://www.worldometers.info/img/flags/small/tn_lo-flag.gif", "youth", "Slovakia", null },
                    { "portugal", "https://www.worldometers.info/img/flags/small/tn_po-flag.gif", "youth", "Portugal", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportCategoryID",
                table: "Countries",
                column: "SportCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
