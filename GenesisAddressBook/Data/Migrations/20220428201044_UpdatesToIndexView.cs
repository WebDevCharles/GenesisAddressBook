using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenesisAddressBook.Data.Migrations
{
    public partial class UpdatesToIndexView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Contacts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Contacts");
        }
    }
}
