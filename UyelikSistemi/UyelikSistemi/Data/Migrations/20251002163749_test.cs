using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UyelikSistemi.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                   name: "FavColor",
                   table: "AspNetUsers",
                   type: "nvarchar(256)",
                   maxLength: 256,
                   nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
