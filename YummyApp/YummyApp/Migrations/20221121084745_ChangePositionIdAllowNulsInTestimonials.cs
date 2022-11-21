using Microsoft.EntityFrameworkCore.Migrations;

namespace YummyApp.Migrations
{
    public partial class ChangePositionIdAllowNulsInTestimonials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Position_PositionId",
                table: "Testimonials");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Testimonials",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Position_PositionId",
                table: "Testimonials",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Position_PositionId",
                table: "Testimonials");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Testimonials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Position_PositionId",
                table: "Testimonials",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
