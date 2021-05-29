using Microsoft.EntityFrameworkCore.Migrations;

namespace branding.Migrations
{
    public partial class TerceraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenName",
                table: "t_product",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenName",
                table: "t_product");
        }
    }
}
