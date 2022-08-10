using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuanDPH.LearnEntityFramework.Migrations
{
    public partial class CreateAndSeedLocationTableOptimized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Viet Nam" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Malay" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3, "Canada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
