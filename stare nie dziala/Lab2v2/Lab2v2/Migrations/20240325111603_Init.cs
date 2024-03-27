using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2v2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toDos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    activity = table.Column<string>(type: "TEXT", nullable: false),
                    accessibility = table.Column<float>(type: "REAL", nullable: false),
                    type = table.Column<string>(type: "TEXT", nullable: false),
                    participants = table.Column<float>(type: "REAL", nullable: false),
                    price = table.Column<float>(type: "REAL", nullable: false),
                    link = table.Column<string>(type: "TEXT", nullable: true),
                    key = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toDos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toDos");
        }
    }
}
