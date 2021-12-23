using Microsoft.EntityFrameworkCore.Migrations;

namespace SeGCore3._1Project.Data.Migrations
{
    public partial class EkleBakimTipiDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BakimTipi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakimAdi = table.Column<string>(nullable: false),
                    BakimFiyati = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakimTipi", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BakimTipi");
        }
    }
}
