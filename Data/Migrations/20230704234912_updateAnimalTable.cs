using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class updateAnimalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sound",
                table: "Animal",
                newName: "Race");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Animal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Animal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Animal");

            migrationBuilder.RenameColumn(
                name: "Race",
                table: "Animal",
                newName: "Sound");
        }
    }
}
