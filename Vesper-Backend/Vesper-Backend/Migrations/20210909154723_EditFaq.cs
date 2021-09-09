using Microsoft.EntityFrameworkCore.Migrations;

namespace Vesper_Backend.Migrations
{
    public partial class EditFaq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Faqs",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Faqs");
        }
    }
}
