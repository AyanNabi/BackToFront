using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack.Migrations
{
    public partial class ContentSliderPropertyIsUpdatedToImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "SliderContent");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "SliderContent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "SliderContent");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "SliderContent",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
