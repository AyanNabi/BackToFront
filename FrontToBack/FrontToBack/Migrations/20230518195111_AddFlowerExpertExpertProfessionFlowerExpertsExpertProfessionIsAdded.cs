using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack.Migrations
{
    public partial class AddFlowerExpertExpertProfessionFlowerExpertsExpertProfessionIsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpertProfessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertProfessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowerExperts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerExperts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpertProfessionFlowerExperts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertProfessionId = table.Column<int>(nullable: false),
                    FlowerExpertId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertProfessionFlowerExperts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpertProfessionFlowerExperts_ExpertProfessions_ExpertProfessionId",
                        column: x => x.ExpertProfessionId,
                        principalTable: "ExpertProfessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertProfessionFlowerExperts_FlowerExperts_FlowerExpertId",
                        column: x => x.FlowerExpertId,
                        principalTable: "FlowerExperts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpertProfessionFlowerExperts_ExpertProfessionId",
                table: "ExpertProfessionFlowerExperts",
                column: "ExpertProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertProfessionFlowerExperts_FlowerExpertId",
                table: "ExpertProfessionFlowerExperts",
                column: "FlowerExpertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertProfessionFlowerExperts");

            migrationBuilder.DropTable(
                name: "ExpertProfessions");

            migrationBuilder.DropTable(
                name: "FlowerExperts");
        }
    }
}
