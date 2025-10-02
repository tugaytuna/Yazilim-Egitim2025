using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitaplikUygulamasi.Migrations
{
    /// <inheritdoc />
    public partial class kitapinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: false),
                    BasimYili = table.Column<int>(type: "int", nullable: false),
                    Okundu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.KitapId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitap");
        }
    }
}
