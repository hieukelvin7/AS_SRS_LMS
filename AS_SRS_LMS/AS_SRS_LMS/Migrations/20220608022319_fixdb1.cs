using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_SRS_LMS.Migrations
{
    public partial class fixdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
