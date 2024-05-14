using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MARKALAR",
                columns: table => new
                {
                    MARKA_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 10 INCREMENT BY 1"),
                    MARKA_ADI = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MARKALAR", x => x.MARKA_ID);
                });

            migrationBuilder.CreateTable(
                name: "MODELLER",
                columns: table => new
                {
                    MODEL_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 10 INCREMENT BY 1"),
                    MODEL_ADI = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    MODEL_YILI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MARKA_ID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODELLER", x => x.MODEL_ID);
                    table.ForeignKey(
                        name: "FK_MODELLER_MARKALAR_MARKA_ID",
                        column: x => x.MARKA_ID,
                        principalTable: "MARKALAR",
                        principalColumn: "MARKA_ID");
                });

            migrationBuilder.CreateTable(
                name: "ARABALAR",
                columns: table => new
                {
                    ARABA_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PLAKA = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    FIYAT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    RESIM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MARKA_ID = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    MODEL_ID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARABALAR", x => x.ARABA_ID);
                    table.ForeignKey(
                        name: "FK_ARABALAR_MARKALAR_MARKA_ID",
                        column: x => x.MARKA_ID,
                        principalTable: "MARKALAR",
                        principalColumn: "MARKA_ID");
                    table.ForeignKey(
                        name: "FK_ARABALAR_MODELLER_MODEL_ID",
                        column: x => x.MODEL_ID,
                        principalTable: "MODELLER",
                        principalColumn: "MODEL_ID");
                });

            migrationBuilder.InsertData(
                table: "MARKALAR",
                columns: new[] { "MARKA_ID", "MARKA_ADI" },
                values: new object[] { 1, "Ferrari" });

            migrationBuilder.InsertData(
                table: "MARKALAR",
                columns: new[] { "MARKA_ID", "MARKA_ADI" },
                values: new object[] { 2, "Volswagen" });

            migrationBuilder.InsertData(
                table: "MARKALAR",
                columns: new[] { "MARKA_ID", "MARKA_ADI" },
                values: new object[] { 3, "TOFAS" });

            migrationBuilder.InsertData(
                table: "MODELLER",
                columns: new[] { "MODEL_ID", "MARKA_ID", "MODEL_ADI", "MODEL_YILI" },
                values: new object[,]
                {
                    { 1, 1, "Enzo", 2010 },
                    { 2, 1, "California", 2016 },
                    { 3, 2, "Golf", 2010 },
                    { 4, 2, "Tiguan", 2018 },
                    { 5, 3, "Kartal", 2000 },
                    { 6, 3, "Dogan", 1999 },
                    { 7, 3, "Serce", 1985 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARABALAR_MARKA_ID",
                table: "ARABALAR",
                column: "MARKA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ARABALAR_MODEL_ID",
                table: "ARABALAR",
                column: "MODEL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MODELLER_MARKA_ID",
                table: "MODELLER",
                column: "MARKA_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARABALAR");

            migrationBuilder.DropTable(
                name: "MODELLER");

            migrationBuilder.DropTable(
                name: "MARKALAR");
        }
    }
}
