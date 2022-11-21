using Microsoft.EntityFrameworkCore.Migrations;

namespace YummyApp.Migrations
{
    public partial class CreatePositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Positon",
                table: "Testimonials");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Testimonials",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Star",
                table: "Testimonials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_PositionId",
                table: "Testimonials",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Position_PositionId",
                table: "Testimonials",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Position_PositionId",
                table: "Testimonials");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_PositionId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Star",
                table: "Testimonials");

            migrationBuilder.AddColumn<string>(
                name: "Positon",
                table: "Testimonials",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
