using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 14, 40, 106, 194, 211, 55, 39, 61, 85, 209, 77, 71, 97, 8, 159, 52, 138, 175, 254, 59, 142, 152, 27, 133, 183, 136, 229, 47, 106, 134, 174, 60, 254, 92, 72, 48, 184, 142, 33, 104, 128, 190, 80, 194, 102, 174, 54, 101, 246, 242, 254, 128, 83, 23, 90, 205, 131, 197, 198, 225, 229, 49, 71, 153 }, new byte[] { 111, 64, 83, 118, 96, 149, 107, 182, 176, 62, 251, 16, 96, 58, 185, 223, 73, 232, 59, 190, 45, 21, 127, 142, 178, 129, 23, 201, 63, 50, 25, 41, 20, 125, 54, 217, 66, 114, 189, 249, 30, 203, 124, 23, 37, 65, 99, 17, 34, 158, 175, 241, 144, 104, 254, 140, 169, 170, 170, 63, 125, 175, 108, 54, 69, 64, 208, 66, 72, 212, 71, 233, 228, 169, 77, 241, 83, 28, 21, 95, 151, 188, 59, 154, 182, 34, 105, 36, 24, 92, 26, 17, 234, 198, 134, 248, 37, 59, 189, 83, 186, 106, 186, 110, 33, 160, 110, 118, 81, 106, 2, 128, 35, 62, 159, 153, 247, 15, 58, 243, 101, 18, 214, 243, 74, 236, 12, 49 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 55, 92, 22, 94, 96, 87, 112, 204, 98, 61, 1, 21, 214, 172, 186, 163, 179, 207, 207, 233, 100, 153, 102, 78, 116, 212, 123, 97, 181, 180, 96, 142, 51, 247, 24, 60, 204, 236, 199, 23, 117, 225, 134, 46, 144, 175, 118, 5, 219, 245, 194, 10, 192, 17, 97, 163, 97, 104, 20, 58, 229, 163, 174, 220 }, new byte[] { 180, 62, 63, 101, 242, 225, 131, 13, 11, 171, 93, 73, 24, 31, 10, 230, 196, 128, 35, 30, 193, 91, 207, 250, 68, 237, 227, 215, 198, 78, 135, 108, 223, 246, 15, 102, 4, 42, 15, 120, 216, 39, 96, 226, 33, 135, 110, 63, 33, 71, 118, 39, 54, 190, 31, 215, 176, 178, 199, 130, 192, 246, 107, 114, 88, 84, 21, 113, 113, 255, 70, 184, 27, 48, 182, 216, 129, 153, 240, 239, 65, 11, 33, 68, 174, 220, 68, 136, 150, 95, 246, 135, 217, 97, 39, 202, 50, 109, 53, 103, 93, 111, 236, 159, 20, 237, 177, 232, 205, 131, 240, 183, 25, 66, 55, 89, 71, 19, 12, 193, 226, 92, 193, 226, 111, 30, 185, 116 } });
        }
    }
}
