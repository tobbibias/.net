using Microsoft.EntityFrameworkCore.Migrations;

namespace Entertainment.DataAccess.Migrations
{
    public partial class scli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Actors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Actors",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
