using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_SRS_LMS.Migrations
{
    public partial class dbfix20061 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_LearningSchedules_DetailScheduleId",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "DetailScheduleId",
                table: "Schedules",
                newName: "LearningScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_DetailScheduleId",
                table: "Schedules",
                newName: "IX_Schedules_LearningScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_LearningSchedules_LearningScheduleId",
                table: "Schedules",
                column: "LearningScheduleId",
                principalTable: "LearningSchedules",
                principalColumn: "LearningScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_LearningSchedules_LearningScheduleId",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "LearningScheduleId",
                table: "Schedules",
                newName: "DetailScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_LearningScheduleId",
                table: "Schedules",
                newName: "IX_Schedules_DetailScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_LearningSchedules_DetailScheduleId",
                table: "Schedules",
                column: "DetailScheduleId",
                principalTable: "LearningSchedules",
                principalColumn: "LearningScheduleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
