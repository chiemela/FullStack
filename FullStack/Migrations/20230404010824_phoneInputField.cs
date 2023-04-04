using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullStack.Migrations
{
    /// <inheritdoc />
    public partial class phoneInputField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "AspNetUsers");
        }
    }
}
