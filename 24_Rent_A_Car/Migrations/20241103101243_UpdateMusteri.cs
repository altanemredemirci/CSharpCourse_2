using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _24_Rent_A_Car.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMusteri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Musteris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Musteris");
        }
    }
}
