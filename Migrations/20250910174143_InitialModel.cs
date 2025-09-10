using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaCsharp.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    PointID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToursPointID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointID);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PointID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourID);
                    table.ForeignKey(
                        name: "FK_Tours_Points_PointID",
                        column: x => x.PointID,
                        principalTable: "Points",
                        principalColumn: "PointID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Tours_TourID",
                        column: x => x.TourID,
                        principalTable: "Tours",
                        principalColumn: "TourID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToursPoint",
                columns: table => new
                {
                    ToursPointID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TourID = table.Column<int>(type: "int", nullable: false),
                    PointID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToursPoint", x => x.ToursPointID);
                    table.ForeignKey(
                        name: "FK_ToursPoint_Points_PointID",
                        column: x => x.PointID,
                        principalTable: "Points",
                        principalColumn: "PointID");
                    table.ForeignKey(
                        name: "FK_ToursPoint_Tours_TourID",
                        column: x => x.TourID,
                        principalTable: "Tours",
                        principalColumn: "TourID");
                    table.ForeignKey(
                        name: "FK_ToursPoint_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Points_ToursPointID",
                table: "Points",
                column: "ToursPointID");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_PointID",
                table: "Tours",
                column: "PointID");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_UserID",
                table: "Tours",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ToursPoint_PointID",
                table: "ToursPoint",
                column: "PointID");

            migrationBuilder.CreateIndex(
                name: "IX_ToursPoint_TourID",
                table: "ToursPoint",
                column: "TourID");

            migrationBuilder.CreateIndex(
                name: "IX_ToursPoint_UserID",
                table: "ToursPoint",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TourID",
                table: "Users",
                column: "TourID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Points_ToursPoint_ToursPointID",
                table: "Points",
                column: "ToursPointID",
                principalTable: "ToursPoint",
                principalColumn: "ToursPointID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Tours_PointID",
                table: "Points",
                column: "PointID",
                principalTable: "Tours",
                principalColumn: "TourID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Users_UserID",
                table: "Tours",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_ToursPoint_ToursPointID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_Tours_PointID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tours_TourID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ToursPoint");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
