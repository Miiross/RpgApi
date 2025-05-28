using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 55, 92, 22, 94, 96, 87, 112, 204, 98, 61, 1, 21, 214, 172, 186, 163, 179, 207, 207, 233, 100, 153, 102, 78, 116, 212, 123, 97, 181, 180, 96, 142, 51, 247, 24, 60, 204, 236, 199, 23, 117, 225, 134, 46, 144, 175, 118, 5, 219, 245, 194, 10, 192, 17, 97, 163, 97, 104, 20, 58, 229, 163, 174, 220 }, new byte[] { 180, 62, 63, 101, 242, 225, 131, 13, 11, 171, 93, 73, 24, 31, 10, 230, 196, 128, 35, 30, 193, 91, 207, 250, 68, 237, 227, 215, 198, 78, 135, 108, 223, 246, 15, 102, 4, 42, 15, 120, 216, 39, 96, 226, 33, 135, 110, 63, 33, 71, 118, 39, 54, 190, 31, 215, 176, 178, 199, 130, 192, 246, 107, 114, 88, 84, 21, 113, 113, 255, 70, 184, 27, 48, 182, 216, 129, 153, 240, 239, 65, 11, 33, 68, 174, 220, 68, 136, 150, 95, 246, 135, 217, 97, 39, 202, 50, 109, 53, 103, 93, 111, 236, 159, 20, 237, 177, 232, 205, 131, 240, 183, 25, 66, 55, 89, 71, 19, 12, 193, 226, 92, 193, 226, 111, 30, 185, 116 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 96, 80, 183, 165, 27, 216, 9, 3, 249, 209, 220, 125, 161, 118, 250, 2, 197, 250, 77, 203, 69, 103, 45, 226, 215, 2, 22, 126, 254, 226, 93, 116, 133, 78, 200, 121, 151, 120, 160, 60, 115, 179, 158, 189, 145, 32, 167, 126, 182, 49, 167, 123, 12, 126, 81, 216, 107, 205, 54, 33, 86, 11, 16, 243 }, new byte[] { 208, 113, 31, 237, 29, 16, 128, 253, 221, 0, 120, 128, 220, 35, 118, 63, 77, 196, 119, 102, 91, 100, 93, 112, 240, 174, 222, 77, 186, 219, 36, 105, 195, 118, 41, 89, 4, 113, 72, 248, 106, 72, 245, 60, 172, 71, 76, 28, 124, 14, 44, 41, 147, 162, 38, 85, 209, 37, 201, 195, 31, 63, 242, 9, 71, 54, 173, 154, 0, 146, 10, 235, 46, 23, 162, 27, 114, 213, 33, 171, 142, 157, 172, 252, 39, 45, 153, 8, 41, 145, 86, 180, 37, 177, 62, 65, 59, 73, 158, 232, 21, 69, 36, 139, 0, 79, 186, 234, 81, 99, 55, 220, 98, 105, 113, 246, 187, 184, 192, 37, 37, 216, 197, 181, 17, 100, 7, 86 } });
        }
    }
}
